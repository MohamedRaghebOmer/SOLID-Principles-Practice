using System;

namespace After
{
    public class Person
    {
        // Virtual method to send an email
        public virtual void SendEmail()
        {
            Console.WriteLine("Sending email to a person...");
        }
    }

    public class Employee : Person
    {
        // Override PaySalary for employees
        public virtual void PaySalary()
        {
            Console.WriteLine("Paying salary to an employee...");
        }

        // Override SendEmail for employees
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to an employee...");
        }
    }

    public class Manager : Employee
    {
        // Override PaySalary for managers
        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to a manager...");
        }

        // Override SendEmail for managers
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to a manager...");
        }
    }

    public class Student : Person
    {
        // Override SendEmail for students
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to a student...");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.PaySalary();   // Calls PaySalary method for Employee
            employee1.SendEmail();   // Calls SendEmail method for Employee

            Employee employee2 = new Manager();
            employee2.PaySalary();   // Calls PaySalary method for Manager
            employee2.SendEmail();   // Calls SendEmail method for Manager

            Person student1 = new Student();
            student1.SendEmail();   // Calls SendEmail method for Student
        }
    }
}
