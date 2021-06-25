using System;

namespace Same_Class_Constructor_Chainning
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

            Student student = new Student(id, firstName, lastName, gender);

            Console.WriteLine(student.GetStudentDetails());
            Console.ReadKey();
        }
    }
}
