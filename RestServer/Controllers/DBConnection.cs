using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RestServer.models;

namespace RestServer.Controllers
{
    class DBConnection
    {
        private MySqlConnection myConnection;
        private string _userID;
        private string _password;
        private string _database;
        private string _server;

        public void SetupUserConnection(string userID, string passWord)
        {
            _userID = userID;//"erik2";
            _password = passWord; //"123321";
            InitializeConnection();
        }


        private void InitializeConnection()
        {
            string myDBconnection;
            _server = "localhost";
            _database = "customers";

            myDBconnection = $"SERVER ={_server}; DATABASE = {_database}; UID = {_userID}; PASSWORD = {_password};";
            myConnection = new MySqlConnection(myDBconnection);
        }

        private bool OpenConnection()
        {
            try
            {
                myConnection.Open();
                return true;
            }catch (MySqlException ex)
            {
                return false;
            }
            
        }

        private bool Disconnect()
        {
            try
            {
                myConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public bool AddNewUser(Person _person)
        {
            string myQuery = "";

            myQuery = $"insert into customerdata (NAME, EMAIL,PHONE, ADDRESS ) values('" +
                        $"{WashOutSQL(_person.Name)}', '{WashOutSQL(_person.Email)}', '" +
                        $"{WashOutSQL(_person.Phone)}','{WashOutSQL(_person.Address)}');";

            return ExecuteQueryDontWait(myQuery);
        }

        public List<Person> GetAllUsers()
        {
            String myQuery = "";
            List<Person> returnList = new List<Person>();
            myQuery = $"select * from customerdata";
            returnList = ExecuteAndReadReply(myQuery);
            return returnList;
        }

        public List<Person> GetSpecificUser(string myString)
        {
            String myQuery = "";
            List<Person> returnList; 
            myQuery = $"select * from customerdata where NAME = '{WashOutSQL(myString)}'";

            returnList = ExecuteAndReadReply(myQuery);
            return returnList;

        }


        private List<Person> ExecuteAndReadReply(string myQuery)
        {
            List<Person> myreturnList = new List<Person>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.CommandText = myQuery;
                sqlCmd.Connection = myConnection;

                MySqlDataReader myReader = sqlCmd.ExecuteReader();

                do
                {
                    while (myReader.Read())
                    {
                        
                            Person thisPerson = new Person(myReader.GetString("NAME"),
                                                           myReader.GetString("EMAIL"),
                                                           myReader.GetString("PHONE"),
                                                           myReader.GetString("ADDRESS"));
                            myreturnList.Add(thisPerson);
                        
                    }
                    
                } while (myReader.NextResult());

                this.myConnection.Close();
            }
            return myreturnList;
        }


        private bool ExecuteQueryDontWait(string myQuery)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.CommandText = myQuery;
                sqlCmd.Connection = myConnection;
                try
                {
                    sqlCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //something went wrong.. 
                    this.myConnection.Close();
                    return false;
                }
                this.myConnection.Close();
                return true;
            }
            return false;
        }

        private string WashOutSQL(string myString)
        {
            //Simple, could do more..
            myString = myString.Replace("\"", "");
            myString = myString.Replace("'","");
            myString = myString.Replace(";", "");
            return myString;
        }
    }
}
