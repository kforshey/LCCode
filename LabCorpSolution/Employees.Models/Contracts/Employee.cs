using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Models.Contracts
{
     public abstract class Employee
    {

      
        protected private float _accumulatedvacationdays { get; set; }

        public float accumulatedvationdays
        {
            get
            {
                return _accumulatedvacationdays;
            }
        }

        public  int maxvacationdays { get; set; }



        public Employee() 
        { 
            _accumulatedvacationdays = 0;
        
        }


        public void Work(int daysworked)
        {
            float vacationearnedperday = (maxvacationdays / 260f);
            _accumulatedvacationdays += (daysworked * vacationearnedperday);
            if (_accumulatedvacationdays > maxvacationdays)
            {
                _accumulatedvacationdays = maxvacationdays;
            }
        }

        public void TakeVacation(float daystaken)
        {
            _accumulatedvacationdays -= daystaken;
            if (_accumulatedvacationdays < 0)
            {
                _accumulatedvacationdays = 0;
            }
        }

    }
}
