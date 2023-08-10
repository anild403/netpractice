using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string City { get; set; }

        public void ChangeDepartment(string department)
        {
            this.Department = department;
        }

        public void ContactEmployee(int phoneNumber)
        {
            Console.WriteLine($"Calling on {phoneNumber}");
        }

        public void ContactEmployee(string emailAddress)
        {
            Console.WriteLine($"Sent an email on {emailAddress}");
        }
        public virtual void TakeADayOff()
        {
            Console.WriteLine("Send an email to the manager");
        }
    }
    public class FullTimeEmployee: Employee
    {
        public int Salary { get; set; }
    }
}
