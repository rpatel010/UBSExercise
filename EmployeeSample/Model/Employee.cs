using System.ComponentModel;

namespace EmployeeSample.Model
{
    public class Employee : INotifyPropertyChanged
    {
        private int employeeId;
        private string employeeName;
        private string department;
        private double salary;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
                OnPropertyChanged("EmployeeId");
            }
        }
        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
                OnPropertyChanged("EmployeeName");
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
                OnPropertyChanged("Department");
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }
    }
}
