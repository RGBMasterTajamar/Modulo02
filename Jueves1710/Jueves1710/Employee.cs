using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Employee : Person
    {
        public int _salary;

        public Employee(int annualSalary) {
        
            _salary = annualSalary;
        }

        //public Employee(int weeklySalary,int numberOfWeeks) {
        //    _salary = weeklySalary + numberOfWeeks;
        //}

        public Employee(int weeklySalary, int numberOfWeeks):this(weeklySalary* numberOfWeeks) { }

        //public string id = "ABC567EFG";

        //public override void GetInfo()
        //{
        //    base.GetInfo();
        //    Console.WriteLine($"Employee ID: {id}");
        //}
    }
}
