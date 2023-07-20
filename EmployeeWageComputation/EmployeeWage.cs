using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        string company;
        int empRatePerHr,numberOfWorkingDays,maxWorkingDays;

        public EmployeeWage(string companyName,int ratePerHr,int workingDays,int maxDays)
        {
            company=companyName;
            empRatePerHr = ratePerHr;
            numberOfWorkingDays = workingDays;
            maxWorkingDays = maxDays;
        }
        
        public void ComputeWage()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalWorkingHrs = 0;
            Console.WriteLine("Welcome To Employee Wage Computation");
            Random random = new Random();
            while (day <= numberOfWorkingDays && totalWorkingHrs <= maxWorkingDays)
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
                empWage = empHrs * empRatePerHr;
                totalWage = totalWage + empWage;
                Console.WriteLine("Day{0} employee wage is:{1}", day, empWage);
                day++;
                totalWorkingHrs = totalWorkingHrs + empHrs;
            }
            
                
            Console.WriteLine("Total Wage for {0} {1} days and Hrs {2} is {3}", company ,(day - 1),totalWorkingHrs , totalWage);
            
        }
    }
}
