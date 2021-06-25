using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_Class_Constructor_Chainning
{
    public class Student
    {
        public Student()
        {

        }
        public Student(string id):this()
        {
            Id = id;   
        }

        public Student(string id,string firstName,string lastName,string gender) : this(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public string GetFullName()
        {
            string fullName = FirstName.Trim() + " " + LastName.Trim();
            return fullName;
        }
        public string GetStudentDetails()
        {
            string details = "---------Student Information-------" + "\n" +
                "Id : " + Id + Environment.NewLine +
                "Name : " + GetFullName() + Environment.NewLine +
                "Gender : " + Gender + Environment.NewLine;
            return details;
        }
    }
}
