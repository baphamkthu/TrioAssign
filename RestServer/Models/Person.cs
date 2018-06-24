using System;

namespace RestServer.models
{
    public class Person
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }


        public Person()
        {

        }

        public Person(string _name, string _email, string _phone, string _address)
        {
            this.Name = _name;
            this.Email = _email;
            this.Phone = _phone;
            this.Address = _address;

        }

    }
}
