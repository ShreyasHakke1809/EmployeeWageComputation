using System.Linq.Expressions;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage("Deloitt", 20, 15, 100);
            employeeWage.ComputeWage();
            EmployeeWage employeeWage1 = new EmployeeWage("Infosys", 25, 20, 105);
            employeeWage1.ComputeWage();
        }
    }    
}