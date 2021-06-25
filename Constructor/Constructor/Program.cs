using System;

namespace Constructor
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //Constructor
        public Student(int id,string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Student Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(id,name,age);

            Console.WriteLine($"Student Id : {student.Id}\nName : {student.Name}\nAge : {student.Age}");
        }
    }
}
