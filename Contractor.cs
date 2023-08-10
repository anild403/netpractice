using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Contractor:Employee
    {
        public int BillRate { get; set; }

        public override void TakeADayOff()
        {
            Console.WriteLine("Send an email and submit the timesheet");
        }

    }
}
