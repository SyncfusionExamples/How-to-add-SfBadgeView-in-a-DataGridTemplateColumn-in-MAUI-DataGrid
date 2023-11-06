using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class EmployeeInfo
    {
        private int employeeID;
        private string employee;
        private string designation;
        private int taskAssigned;
        private int taskPending;
        private double salary;
        private string status;
        

        public int EmployeeID
        {
            get { return employeeID; }
            set { this.employeeID = value; }
        }
        public string Employee
        {
            get { return this.employee; }
            set { this.employee = value; }
        }
        public string Designation
        {
            get { return this.designation; }
            set { this.designation = value; }
        }

        public int TaskAssigned
        {
            get { return taskAssigned; }
            set { this.taskAssigned = value; }
        }

        public int TaskPending
        {
            get { return taskPending; }
            set { this.taskPending = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }
        public string Status
        {
            get { return status; }
            set { this.status = value; }
        }



        public EmployeeInfo( int employeeID, string employee, string designation, int taskAssigned, int taskPending, double salary, string status)
        {
            this.EmployeeID = employeeID;
            this.Employee = employee;
            this.Designation = designation;
            this.TaskAssigned = taskAssigned;
            this.TaskPending = taskPending;
            this.Salary = salary;
            this.Status = status;
        }
    }
}
