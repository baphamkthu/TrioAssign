using System;
using System.Collections.Generic;
using System.Web.Http;
using RestServer.models;


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
            return myPersonList;// JsonConvert.SerializeObject(myPersonList); ;
        }


        // GET: api/RestServer/5
        public List<Person> Get(String id)
        {
            DBConnection myConn = new DBConnection();
            List<Person> myPersonList = new List<Person>();
            myConn.SetupUserConnection("erik2", "123321");

            myPersonList = myConn.GetSpecificUser(id);

            return myPersonList;
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
