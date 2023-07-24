using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        public List<Company> companyEmpWageList;

        public static Random random = new Random();

        public EmployeeWage()
        {
            companyEmpWageList = new List<Company>();
        }
        public void AddCompanyEmpWageToList(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            Company companyEmpWage = new Company(company, emp_Wage_Per_Hr, working_Days_Per_Month, max_Hrs_Per_Month);
            companyEmpWageList.Add(companyEmpWage);
        }
        public void ComputeEmpWage()
        {
            foreach (Company empWage in companyEmpWageList)
            {
                empWage.SetTotalWage(ComputeWage(empWage));
                Console.WriteLine(empWage.ToString());
            }
        }
        public int ComputeWage(Company company)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalWorkingHrs = 0;
            Random random = new Random();
            while (day <= company.numberOfWorkingDays && totalWorkingHrs <= company.maxWorkingDays)
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
                empWage = empHrs * company.empRatePerHr;
                totalWage = totalWage + empWage;
               // Console.WriteLine("Day{0} employee wage is:{1}", day, empWage);
                day++;
                totalWorkingHrs = totalWorkingHrs + empHrs;
                if (totalWorkingHrs > company.maxWorkingDays)
                    totalWorkingHrs = totalWorkingHrs - empHrs;
            }
            
                
            Console.WriteLine("Total Wage for {0} {1} days and Hrs {2} is {3}", company.companyN , (day - 1), totalWorkingHrs , totalWage);
            return totalWage;
            
        }
    }
}
