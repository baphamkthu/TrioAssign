using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestServer.models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace TrionaAssignment
{
     class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        public static async Task<List<Person>> getMultiplePerson()
        {
            List<Person> Mylist = new List<Person>();
            HttpClient myClient = NewHttpClient();
            var response = await myClient.GetAsync("api/RestServer/");
            var ResultList = await response.Content.ReadAsAsync<List<Person>>();
            Mylist = ResultList;

            return Mylist;
        }

        public static async Task<List<Person>> getSelectedPerson(string myRequest)
        {
            HttpClient myClient = NewHttpClient();
            var response = await myClient.GetAsync("api/RestServer/" + myRequest);
            var ResultPerson = await response.Content.ReadAsAsync<List<Person>>();
            return ResultPerson;

        }



        public static async void saveNewPerson(Person myPerson) 
        {
            HttpClient myClient = NewHttpClient();
            var response = await myClient.PostAsJsonAsync("api/RestServer/", myPerson);
            var responseString = await response.Content.ReadAsStringAsync(); 
        }



        private static HttpClient NewHttpClient()
        {
            HttpClient myClient = new HttpClient();
            myClient.BaseAddress = new Uri("http://localhost:59027");
            myClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return myClient;
        }


    }
}
