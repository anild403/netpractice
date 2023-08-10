using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee employee = new FullTimeEmployee();
            employee.FirstName = "Rushitha";
            employee.LastName = "LastName";
            employee.Department = "Finance";
            employee.City = "Austin";
            employee.Salary = 60000;

            Console.WriteLine($"Firstname of the employee is :{employee.FirstName}");
            Console.WriteLine($"LastName of the employee is :{employee.LastName}");
            Console.WriteLine($"Department of the employee is :{employee.Department}");
            Console.WriteLine($"City of the employee is :{employee.City}");


            employee.ChangeDepartment("IT");
            Console.WriteLine("Employee needs a day off");

            employee.TakeADayOff();

            Console.WriteLine($"Updated Department of the employee is :{employee.Department}");
            Contractor contractor = new Contractor();
            contractor.FirstName = "Rushitha";
            contractor.LastName = "LastName";
            contractor.Department = "Finance";
            contractor.City = "Austin";
            contractor.BillRate = 60;

            Console.WriteLine("Contractor needs a day off");
            contractor.TakeADayOff();

            Console.WriteLine("Call employee on phone number");
            contractor.ContactEmployee(9999999);

            Console.WriteLine("send employee an email");
            contractor.ContactEmployee("abc@def.com");


            Console.WriteLine($"Employee gets a discount of {GetEmployeeDiscount(employee)}%"); ;
            AreSalaryBillsNeeded(employee);
            
        }

        private static void AreSalaryBillsNeeded(FullTimeEmployee employee)
        {
           //if(employee.Salary >100000)
           // {
           //     Console.WriteLine("Employee should submit travel bills");
           // }
           //else
           // {
           //     Console.WriteLine("Employee doesn't have to submit travel bills");

           // }
            string message = string.Empty;
           message =  (employee.Salary > 100000) ? "Employee should submit travel bills" : "Employee doesn't have to submit travel bills";
            Console.WriteLine(message);
        }

        private static int GetEmployeeDiscount(FullTimeEmployee employee)
        {
            int discount = 0;
            switch(employee.City)
            {
                case "Jersey City":
                    discount = 30;
                    break;
                case "Los Angeles":
                    discount = 35;
                    break;
                case "Austin":
                    discount = 10;
                    break;
                default:
                    discount = 15;
                        break;

            }
            return discount;
        }
    }
}
