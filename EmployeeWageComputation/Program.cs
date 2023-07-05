using System.Linq.Expressions;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;

            Console.WriteLine("Welcome To Employee Wage Computation");
            Random random = new Random();   
            int employeeInput = random.Next(0,3);
            Console.WriteLine("Random value:{0}", employeeInput);
            switch(employeeInput)
            {
                case PART_TIME:
                    Console.WriteLine("FullTime Employee Is Present");
                    empHrs = 8;
                    break;
                case FULL_TIME:
                    Console.WriteLine("PartTime Employee Is Present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee Is Absent");
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Daily Employee Wage is:{0}", empWage);
            
        }
    }
}