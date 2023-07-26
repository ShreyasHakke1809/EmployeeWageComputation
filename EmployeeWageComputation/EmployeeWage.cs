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
        public Dictionary<string, int> keyValue;
        public EmployeeWage()
        {
            companyEmpWageList = new List<Company>();
            keyValue = new Dictionary<string, int>();
        }
        public void AddCompanyEmpWageToList(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            Company companyEmpWage = new Company(company, emp_Wage_Per_Hr, working_Days_Per_Month, max_Hrs_Per_Month);
            companyEmpWageList.Add(companyEmpWage);         
        }
        public void ComputeEmpWage()
        {
            foreach (Company comp in companyEmpWageList)
            {
                int totalWage = ComputeWage(comp);
                comp.SetTotalWage(totalWage);
                Console.Write(comp);
                keyValue.Add(comp.companyN, comp.totalWage);
            }
        }
        public int GetTotalWageBasedOnCompany(string companyN)
        {
            return keyValue[companyN];
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
            List<int> listofDailyWages = new List<int>();         
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
                listofDailyWages.Add(empWage);
                totalWage = totalWage + empWage;
                Console.WriteLine("Day{0} employee wage is:{1}", day, empWage);
                day++;
                totalWorkingHrs = totalWorkingHrs + empHrs;
                if (totalWorkingHrs > company.maxWorkingDays)
                    totalWorkingHrs = totalWorkingHrs - empHrs;
            }
            Console.WriteLine("\nDaily wage for {0} is:",company.companyN);
            foreach (int wage in listofDailyWages)
            {
                  Console.Write(wage+" ");
            }
            Console.WriteLine("Total Days: {0}, Total working hours: {1} ", (day-1),empHrs);
            Console.WriteLine("Total Employee Wage for company " + company.companyN + " is: " + company.totalWage + "\n");
            return company.totalWage;
            
        }
    }
}
