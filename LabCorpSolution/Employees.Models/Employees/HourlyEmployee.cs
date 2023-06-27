using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Employees.Models.Contracts;

namespace Employees.Models.Employees
{
    public class HourlyEmployee : Employee
    {

        public HourlyEmployee() 
        {
            maxvacationdays = 10;   
            
        }

        //public void Work(int daysworked)
        //{
        //    accumulatedvacationdays += daysworked * (10 / 260);
        //    if (accumulatedvacationdays > maxvacationdays)
        //    {
        //        accumulatedvacationdays = maxvacationdays;
        //    }
        //}
    }
}
