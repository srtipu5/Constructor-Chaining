using System;

namespace Base_Class_Constructor_Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Id : ");
            string id = Console.ReadLine();

            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Gender : ");
            string gender = Console.ReadLine();

            Console.Write("Enter Address : ");
            string address = Console.ReadLine();

            Console.Write("Enter SSC GPA : ");
            double sscGPA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter HSC GPA : ");
            double hscGPA = Convert.ToDouble(Console.ReadLine());

            Student student = new Student(firstName,lastName,gender,address,id,sscGPA,hscGPA);
            Console.WriteLine(student.StudentInfo());
            Console.ReadKey();
        }
    }
}
