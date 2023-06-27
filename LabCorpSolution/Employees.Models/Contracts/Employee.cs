using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Models.Contracts
{
     public abstract class Employee
    {
        protected internal float accumulatedvacationdays { get; set; }


        public  int maxvacationdays { get; set; }


        public Employee() 
        { 
            accumulatedvacationdays = 0;
        
        }


        public void Work(int daysworked)
        {
            accumulatedvacationdays += daysworked * (maxvacationdays / 260);
            if (accumulatedvacationdays > maxvacationdays)
            {
                accumulatedvacationdays = maxvacationdays;
            }
        }

        public void TakeVacation(float daystaken)
        {
            accumulatedvacationdays -= daystaken;
        }

    }
}
