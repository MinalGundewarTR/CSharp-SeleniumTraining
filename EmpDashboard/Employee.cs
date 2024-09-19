using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee
    {
        public int empID;
        public string empName;
        public double empSalary;
        public string empPerformance;
        public static string companyName;

        //Constructor without parameter.
        public Employee() 
        {
            Console.WriteLine("Constructor without parameter called");
        }

        //Constructor with parameter
        public Employee(int empID)
        {
            Console.WriteLine("Constructor with parameter created");
            this.empID = empID;

        }
        //Constructor overloading
        public Employee(int empID,string empName)
        {
            Console.WriteLine("Constrctor overloading example");
            this.empID= empID;
            this.empName = empName; 

        }
        public int EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                if (value > 100) { empID = value; }
                else { Console.WriteLine("Currently employee ID is 0. Please provide value more than 0"); }
            }
        }

        public string EmpPerformance
        {
            //get { return empPerformance; }
            set 
            {
                if (value.Equals("A") || value.Equals("B") || value.Equals("C"))
                {
                    empPerformance = value;
                }
                else
                {
                    Console.WriteLine("Please provide employee performace value either A,B or C");
                }
            }
        }


        public void DisplayEmployeeDetails()
        {
            AllocateBonus();
            Console.WriteLine("Employee ID = " + empID );
            Console.WriteLine("Employee Name = "+ empName );
            Console.WriteLine("Employee Salary = " + empSalary );
            Console.WriteLine("Employee Performance = "+ empPerformance );
            Console.WriteLine("Company Name = " + companyName);
            Console.WriteLine("---------------------------------------------------");
        }

        public void AllocateBonus()

        {
            if (empPerformance != null)
            {
                if (empPerformance == "A")
                {
                    empSalary = empSalary + 1000;
                }
                else if (empPerformance == "B")
                {
                    empSalary = empSalary + 500;
                }
                else
                {
                    empSalary = empSalary + 100;
                }
            }
        }
    }
}
