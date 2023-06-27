using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Employees.Models.Contracts;

using Microsoft.Win32;

namespace Employees.Models.Employees
{
    public class SalariedEmployee : Employee
    {

        


        public SalariedEmployee() 
        {
            maxvacationdays = 15;
                    
        }

        //public void Work(int daysworked)
        //{
        //    accumulatedvacationdays += daysworked * (15 / 260);
        //    if (accumulatedvacationdays > maxvacationdays)
        //    {
        //        accumulatedvacationdays = maxvacationdays;
        //    }
        //}
    }
}
