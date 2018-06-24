using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestServer.models;

namespace TrionaAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void button_clearFields_click(object sender, EventArgs e)
        {

            this.ClearFields();
        }

        private void button_writePerson_click(object sender, EventArgs e)
        {
            Person myPerson = GetUserFromFields();
            Program.saveNewPerson(myPerson);

        }


    

        private void button_getAllUsers_click(object sender, EventArgs e)
        {

            try
            {
                Task<Person> myTask = Task.Run(() => Program.getSelectedPerson(textbox_search.Text));
                myTask.Wait();
                Person myresult = myTask.Result;
                ShowUser(myresult);
               
            
            }
            catch (Exception ex)
            {

            }

        }


        private void ShowUser(Person person)
        {
            this.textbox_name.Text = person.Name;
            this.textbox_email.Text = person.Email;
            this.textbox_phone.Text = person.Phone;
            this.textbox_address.Text = person.Address;
        }

        private Person GetUserFromFields()
        {
            Person _person = new Person(this.textbox_name.Text,
                                        this.textbox_email.Text,
                                        this.textbox_phone.Text,
                                        this.textbox_address.Text);
            return _person;
        }

        private void ClearFields()
        {
            this.textbox_search.Text = "";
            this.textbox_name.Text = "";
            this.textbox_email.Text = "";
            this.textbox_phone.Text = "";
            this.textbox_address.Text = "";
        }



        // Just a set of TestData
        //private List<Person> LoadPersonList()  
        //{
        //    List < Person > thisList = new List<Person>();
        //    thisList.Add(new Person("a", "b", "c", "d"));
        //    thisList.Add(new Person("x", "b", "c", "d"));
        //    thisList.Add(new Person("y", "b", "c", "d"));
        //    return thisList;
        //}

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
