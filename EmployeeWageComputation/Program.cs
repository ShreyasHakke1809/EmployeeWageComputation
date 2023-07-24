using System.Linq.Expressions;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.AddCompanyEmpWageToList("Deloitt", 20, 15, 100);
            employeeWage.AddCompanyEmpWageToList("Microsoft", 25, 20, 105);
            employeeWage.ComputeEmpWage();
        }
    }    
}