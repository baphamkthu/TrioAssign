using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestServer.models;
using Newtonsoft.Json;


namespace RestServer.Controllers
{
    public class RestServerController : ApiController
    {
        // GET: api/RestServer
        public List<Person> Get()
        {

            List<Person> myPersonList = new List<Person>();
            DBConnection myConn = new DBConnection();
            myConn.SetupUserConnection("erik2", "123321");
            myPersonList = myConn.GetAllUsers();
            //var thisString = 
            return myPersonList;// JsonConvert.SerializeObject(myPersonList); ;
        }


        // GET: api/RestServer/5
        public Person Get(String id)
        {
            DBConnection myConn = new DBConnection();
            Person myPerson;
            myConn.SetupUserConnection("erik2", "123321");

            myPerson = myConn.GetSpecificUser(id);

            return myPerson;
        } 


        // POST: api/RestServer
        public void Post([FromBody]Person value)
        {
            DBConnection myConn = new DBConnection();

            myConn.SetupUserConnection("erik2", "123321");
            myConn.AddNewUser(value);

            
            }

        // PUT: api/RestServer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RestServer/5
        public void Delete(int id)
        {


        }
    }
}
