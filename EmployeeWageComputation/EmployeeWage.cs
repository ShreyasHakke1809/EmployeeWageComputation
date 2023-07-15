using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        const int EMP_RATE_PER_HR = 20;
        const int NUMBER_OF_WORKING_DAYS = 20;
        const int MAX_WORKING_DAYS = 100;
        public void ComputeWage()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalWorkingHrs = 0;
            Console.WriteLine("Welcome To Employee Wage Computation");
            Random random = new Random();
            while (day <= NUMBER_OF_WORKING_DAYS && totalWorkingHrs <= MAX_WORKING_DAYS)
            {
                int employeeInput = random.Next(0, 3);
                switch (employeeInput)
                {
                    case PART_TIME:
                        empHrs = 8;
                        break;
                    case FULL_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                totalWage = totalWage + empWage;
                Console.WriteLine("Day{0} employee wage is:{1}", day, empWage);
                day++;
                totalWorkingHrs = totalWorkingHrs + empHrs;
            }
            Console.WriteLine("Total Wage for {0} days is:{1}", (day - 1), totalWage);
        }
    }
}
