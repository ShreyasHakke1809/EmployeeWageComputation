using System.Linq.Expressions;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage(); 
            employeeWage.ComputeWage(); 
        }
    }    
}