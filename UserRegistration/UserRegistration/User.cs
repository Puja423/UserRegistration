using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class User
    {
         
        public string firstName;
        public string lastName;
        public string emailId;
        public string phoneNumber;
        public string passWord;
        public string emailList;




        public User(String firstname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }

        public User()
        {
        }

        public string FirstName { get; set; }
        private string firstname = "^[A-Z][a-z]{2,}$";
        public string LastName { get; set; }
        private string lastname = "^[A-Z][a-z]{2,}$";

        public void GetInputs()
        {

            Console.Write("enter the first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Firstname:" + firstName);
            Console.Write("Enter the  last name");
            string lastName = Console.ReadLine();



        }

        public bool VerifyfirstName(string firstName)
        {

            return Regex.IsMatch(firstName, firstName);


        }
        public bool VerifylastName(string lastname)
        {

            return Regex.IsMatch(LastName, lastname);


        }
    }
}