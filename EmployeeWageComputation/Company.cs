using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Company
    {
        public string companyN;
        public int empRatePerHr, numberOfWorkingDays, maxWorkingDays,totalWage;

        public Company(string companyName, int ratePerHr, int workingDays, int maxDays)
        {
            companyN = companyName;
            empRatePerHr = ratePerHr;
            numberOfWorkingDays = workingDays;
            maxWorkingDays = maxDays;
        }
        public void SetTotalWage (int total)
        {
            totalWage = total;
        }
    }
}
