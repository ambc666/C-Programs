using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Age
{
    class Program
    {
            static int getAgeFromDateOfBirth(int day, int month, int year)
            {
                DateTime dob = new DateTime(year, month, day);
                DateTime Now = DateTime.Now;
                int Years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
                DateTime PastYearDate = dob.AddYears(Years);
                int Months = 0;
                for (int i = 1; i <= 12; i++)
                {
                    if (PastYearDate.AddMonths(i) == Now)
                    {
                        Months = i;
                        break;
                    }
                    else if (PastYearDate.AddMonths(i) >= Now)
                    {
                        Months = i - 1;
                        break;
                    }
                }

                return Years;
            }


            static void Main(string[] args)
            {
                int dob_day, dob_month, dob_year;

                Console.WriteLine("Enter day of birth:");
                dob_day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter month of birth:");
                dob_month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter year of birth:");
                dob_year = Convert.ToInt32(Console.ReadLine());

                int age = Program.getAgeFromDateOfBirth(dob_day, dob_month, dob_year);

                if (age <= 12)
                {
                    Console.WriteLine(String.Format("You are {0}", age));
                    Console.WriteLine("You can enjoy films rated U and PG");
                }
                if (age > 12 && age < 15)
                {
                    Console.WriteLine(String.Format("You are {0}", age));
                    Console.WriteLine("You can enjoy films rated U, PG, 12A and 12");
                }
                if (age > 15 && age < 18)
                {
                    Console.WriteLine(String.Format("You are {0}", age));
                    Console.WriteLine("You can enjoy films rated U, PG, 12A, 12 and 15");
                }
                else
                {
                    Console.WriteLine(String.Format("You are {0}", age));
                    Console.WriteLine("You can enjoy all films, with no age restriction");
                }

                Console.ReadLine();
            }
        }
    }