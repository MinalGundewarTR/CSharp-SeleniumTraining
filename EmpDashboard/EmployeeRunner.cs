using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner
    {
        static void Main(string[] args)
        {
            Employee.companyName = "TR";

            Employee objEmp1 = new Employee(101);
            Employee objEmp2 = new Employee(102);
            Employee objEmp3 = new Employee(103, "Kim");

            //objEmp1.EmpID = 101;
            objEmp1.empName = "Saul"; objEmp1.empSalary = 9000; objEmp1.EmpPerformance = "D";

            //objEmp2.EmpID = 102;
            objEmp2.empName = "Peter"; objEmp2.empSalary = 7000; objEmp2.EmpPerformance = "A";

            //objEmp3.empID=103; objEmp3.empName = "Kim"; 
            objEmp3.empSalary = 4000; objEmp3.EmpPerformance = "C"; 

            //Console.WriteLine(objEmp1.empName);
            //Console.WriteLine(objEmp2.empName);
            //Console.WriteLine(objEmp3.empName);
            //Console.WriteLine(Employee.companyName);

            objEmp1.DisplayEmployeeDetails();
            objEmp2.DisplayEmployeeDetails();
            objEmp3.DisplayEmployeeDetails();

            
        }
    }
}
