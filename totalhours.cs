using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empprogam
{
    internal class totalhours
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 10;

        public static void viewhrs()
        {
            int empHrs = 0;
            int TotalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays <NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                TotalEmpHrs += empHrs;
                Console.WriteLine("Day#: "+ totalWorkingDays + "Emp Hrs: " + empHrs);

            }
            int totalEmpWage = TotalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : "+totalEmpWage);

        }
    }


}
    

