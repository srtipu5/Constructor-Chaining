using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Class_Constructor_Chaining
{
    public class Student : Person
    {
        public Student(string firstName,string lastName,string gender,string
            address):base(firstName,lastName,gender,address)
        {
                
        }

        public Student(string firstName, string lastName, string gender, string
          address,string studentId,double sscGPA,double hscGPA) : this (firstName, lastName, gender, address)
        {
            StudentId = studentId;
            SSCGPA = sscGPA;
            HSCGPA = hscGPA;
        }

        public string StudentId { get; set; }
        public double SSCGPA { get; set; }
        public double HSCGPA { get; set; }

        public double GetAvgGPA()
        {
            double avgGPA = (SSCGPA + HSCGPA) / 2;
            avgGPA = Math.Round(avgGPA,2);
            return avgGPA;
        }
        public string StudentInfo()
        {
            string info = "---------Student Info--------"+"\n"+"Student Id : " + StudentId + Environment.NewLine +
                          "Name : " + GetFullName() + Environment.NewLine +
                          "Gender : " + Gender + Environment.NewLine +
                          "Address : " + Address + Environment.NewLine+
                          "Average GPA : " + GetAvgGPA() + Environment.NewLine;
            return info;
        }
    }
}
