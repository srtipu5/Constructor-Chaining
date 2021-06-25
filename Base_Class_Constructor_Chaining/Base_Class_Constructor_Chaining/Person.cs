using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class_Constructor_Chaining
{
   public class Person
    {
        public Person(string firstName,string lastName,string gender,string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public string GetFullName()
        {
            string fullName = FirstName.Trim() + " " + LastName.Trim();
            return fullName;
        }
    }
}
