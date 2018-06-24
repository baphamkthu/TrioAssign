using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrionaAssignment
{
    class DBConnection
    {
        private MySqlConnection myConnection;
        private string _userID;
        private string _password;
        private string _database;
        private string _server;

        //public void DBConnect()
        //{
        //    InitializeConnection();   
        //}

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
                MessageBox.Show(ex.Message);

            }
            return false;
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

                MessageBox.Show(ex.Message);
            }

            return false;
        }



        public bool AddNewUser(Person _person)//String Name, String Email, String Phone, String Address)
        {
            string myQuery = "";

            myQuery = $"insert into customerdata (NAME, EMAIL,PHONE, ADDRESS ) values('{_person.Name}', '{_person.Email}', {_person.Phone},'{_person.Address}');";
            return ExecuteQueryDontWait(myQuery);
        }

        public bool ListAllUsers()
        {
            return false;
        }

        public Person GetSpecificUser(int ID)
        {
            return new Person("","","","");
        }

        public Person GetSpecificUser(string myString)
        {
            String myQuery = "";
            List < Person > returnList;
            if (myString.Contains("@")){
                myQuery = $"select * from customerdata where EMAIL = '{myString}'";
            }else {
                myQuery = $"select * from customerdata where NAME = '{myString}'";
            }

            returnList = ExecuteAndReadReply(myQuery);


            if (returnList.Count == 1)
            {
                return returnList[0];
            }
            else // something has gone wrong here...
            {
                return new Person("", "", "", "");
            }
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

                while (myReader.Read())
                {

                    Person thisPerson = new Person(myReader.GetString("NAME"),
                                                   myReader.GetString("EMAIL"),
                                                   myReader.GetString("PHONE"),
                                                   myReader.GetString("ADDRESS"));
                    myreturnList.Add(thisPerson);
                    myReader.NextResult();
                }

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
                    sqlCmd.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {

                }
                this.myConnection.Close();
                return true;
            }
            return false;
        }
    }
}
