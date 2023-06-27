using Employees.Models.Contracts;
using Employees.Models.Employees;

using Microsoft.AspNetCore.Components;

namespace Employees.UI.Components
{
    public partial class EmployeeComponent
    {
        [Parameter]
        public Employee employee { get; set; }

        private int daysworked { get; set; }

        private float vacationtime { get; set; }    

        public EmployeeComponent() 
        { 
        }


        private void Work()
        {
            employee.Work(daysworked);
        }

        private void TakeVacation()
        {
            if (employee.accumulatedvationdays >= vacationtime)
            {
                employee.TakeVacation(vacationtime);
            }
        }



    }
}
