using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Employees.Models.Contracts;

namespace Employees.Models.Employees
{
    public class Manager : Employee
    {
        public Manager() 
        {
            maxvacationdays = 30;
        
        }

        //public void Work(int daysworked)
        //{
        //    accumulatedvacationdays += daysworked * (30 / 260);
        //    if (accumulatedvacationdays > maxvacationdays)
        //    {
        //        accumulatedvacationdays = maxvacationdays;
        //    }
        //}
    }
}
