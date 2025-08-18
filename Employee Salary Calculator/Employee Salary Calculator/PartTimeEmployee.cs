using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System; 

namespace EmployeeApplication.EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        
        private string _firstName;
        private string _lastName;
        private string _department;
        private string _jobTitle;
        private double _basicSalary;
        private double _ratePerHour; 
        private double _totalHoursWorked; 


       
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public double BasicSalary
        {
            get { return _basicSalary; }
            set { _basicSalary = value; }
        }

        
        public double RatePerHour
        {
            get { return _ratePerHour; }
            set { _ratePerHour = value; }
        }

        public double TotalHoursWorked
        {
            get { return _totalHoursWorked; }
            set { _totalHoursWorked = value; }
        }

        
        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle, double ratePerHour, double totalHoursWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            JobTitle = jobTitle;
            RatePerHour = ratePerHour;
            TotalHoursWorked = totalHoursWorked;
            
        }

        
        public void computeSalary(double rate, double totalHours)
        {
            
            BasicSalary = rate * totalHours;
        }

        
        public double getSalary()
        {
            return BasicSalary;
        }
    }
}
