using Employees.Models;
using Employees.Models.Contracts;
using Employees.Models.Employees;

namespace Employees.UI.Pages
{
    public partial class Index
    {
        List<Employee> Employees { get; set; } = new List<Employee>();
        HourlyEmployee h1;
        HourlyEmployee h2;
        HourlyEmployee h3;
        SalariedEmployee s1;
        SalariedEmployee s2;
        SalariedEmployee s3;
        Manager m1;
        Manager m2;
        Manager m3;
        Manager m4;


        public Index() 
        { 
            h1 = new HourlyEmployee();
            h2 = new HourlyEmployee();
            h3 = new HourlyEmployee();
            s1 = new SalariedEmployee();
            s2 = new SalariedEmployee();
            s3 = new SalariedEmployee();
            m1 = new Manager();
            m2 = new Manager();
            m3 = new Manager();
            m4 = new Manager();
            Employees = new List<Employee>() {h1, h2, h3, s1, s2, s3, m1, m2, m3, m4 };
        
        
        }
    }
}
