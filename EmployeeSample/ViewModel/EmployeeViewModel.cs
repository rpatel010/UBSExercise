using EmployeeSample.Model;
using System.Collections.Generic;

namespace EmployeeSample.ViewModel
{
    public class EmployeeViewModel
    {
        private IList<Employee> _EmployeesList;
        public EmployeeViewModel()
        {
            _EmployeesList = new List<Employee>
            {
                new Employee{EmployeeId = 12345, EmployeeName = "Derek", Department = "IT", Salary = 55000.34},
                new Employee{EmployeeId = 383848, EmployeeName = "Mark", Department = "HR", Salary = 61000},
                new Employee{EmployeeId = 2828383, EmployeeName = "Lisa", Department = "IT", Salary = 59999.99},
                new Employee{EmployeeId = 607075, EmployeeName = "James", Department = "Operations", Salary = 80000}
            };
        }

        public IList<Employee> Employees
        {
            get { return _EmployeesList; }
            set { _EmployeesList = value; }
        }
    }
}
