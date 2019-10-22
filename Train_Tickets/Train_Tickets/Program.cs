using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double adult1 = 13.00; //Journey 1 - Coatbridge to Carlisle
            double child1 = 6.50;
            double adult2 = 10.50; //Journey 2 - Motherwell to Carlisle
            double child2 = 5.25;

            Console.WriteLine("Please select a Journey to continue, Please enter 1 or 2"); // Pick a journey 1 or 2.
            Console.WriteLine("1 : Journey 1 Coatbridge to Carlisle ");
            Console.WriteLine("2 : Journey 2 Motherwell to Carlisle ");
            string journey = Console.ReadLine();

            switch (journey)
            {
                /************Case 1 Here********/
                case "1":
                    Console.WriteLine("You have selected Coatbridge to Carlisle");  // This is the code for Coatbridge to Carlisle which I have named 1.
                    Console.WriteLine("Please enter how many adult tickets for this journey:");
                    double adult1Number = Convert.ToInt32(Console.ReadLine());

                    double adult1Total = adult1 * adult1Number;

                    Console.WriteLine("Please enter how many child tickets for this journey:");
                    double child1Number = Convert.ToInt32(Console.ReadLine());

                    double child1Total = child1 * child1Number;
                    double journey1 = adult1Total + child1Total;

                    Console.WriteLine("The total cost of the journey is £{0}", journey1.ToString("F")); //This string makes the double show double decimal value, without it it shows £0.5 instead of £0.50.
                    Console.ReadLine();

                    if (adult1Number + child1Number == 1) // If 1 person then no discount
                    {
                        Console.WriteLine("You do not qualify for a Discount at this time.");
                    }
                    if (adult1Number + child1Number == 2) // If 2 then discount of 5% to be applied
                    {
                        Console.WriteLine("You qualify for a 5% Discount. \nYour total cost for tickets including discount is {0:c}", journey1 - ((journey1 * 5) / 100)); //Found {0:c} is also for currency, No £ required either.  .ToString was not working in the calculations.
                    }
                    if (adult1Number + child1Number >= 3 && adult1Number + child1Number <= 5) // If 3-5 then discount of 8% to be applied
                    {
                        Console.WriteLine("You qualify for a 8% Discount. \nYour total cost for tickets including discount is {0:c}", journey1 - ((journey1 * 8) / 100));
                    }
                    if (adult1Number + child1Number >= 6 && adult1Number + child1Number <= 10) // If 6-10 then discount of 12% to be applied
                    {
                        Console.WriteLine("You qualify for a 12% Discount. \nYour total cost for tickets including discount is {0:c}", journey1 - ((journey1 * 12) / 100));
                    }
                    if (adult1Number + child1Number >= 11) // If 11+ then discount of 15% to be applied
                    {
                        Console.WriteLine("You qualify for a 15% Discount. \nYour total cost for tickets including discount is {0:c}", journey1 - ((journey1 * 15) / 100));
                    }
                    break;

                /************Case 2 Here********/
                case "2":
                    Console.WriteLine("You have selected Motherwell to Carlisle");  //This is the code for Motherwell to Carlisle which I have named 2.
                    Console.WriteLine("Please enter how many adult tickets for this journey:");
                    double adult2Number = Convert.ToInt32(Console.ReadLine());

                    double adult2Total = adult2 * adult2Number;

                    Console.WriteLine("Please enter how many child tickets for this journey:");
                    double child2Number = Convert.ToInt32(Console.ReadLine());

                    double child2Total = child2 * child2Number;
                    double journey2 = adult2Total + child2Total;

                    Console.WriteLine("The total cost of the journey is £{0}", journey2.ToString("F")); //This string makes the double show double decimal value, duplicate of prev case only variable are changed, double shows double decimal unless it ends with a 0 so is required.
                    Console.ReadLine();

                    if (adult2Number + child2Number == 1) // If 1 person then no discount
                    {
                        Console.WriteLine("You do not qualify for a Discount at this time.");
                    }
                    if (adult2Number + child2Number == 2) // If 2 then discount of 5% to be applied
                    {
                        Console.WriteLine("You qualify for a 5% Discount. \nYour total cost for tickets including discount is {0:c}", journey2 - ((journey2 * 5) / 100));
                    }
                    if (adult2Number + child2Number >= 3 && adult2Number + child2Number <= 5) // If 3-5 then discount of 8% to be applied
                    {
                        Console.WriteLine("You qualify for a 8% Discount. \nYour total cost for tickets including discount is {0:c}", journey2 - ((journey2 * 8) / 100));
                    }
                    if (adult2Number + child2Number >= 6 && adult2Number + child2Number <= 10) // If 6-10 then discount of 12% to be applied
                    {
                        Console.WriteLine("You qualify for a 12% Discount. \nYour total cost for tickets including discount is {0:c}", journey2 - ((journey2 * 12) / 100));
                    }
                    if (adult2Number + child2Number >= 11) // If 11+ then discount of 15% to be applied
                    {
                        Console.WriteLine("You qualify for a 15% Discount. \nYour total cost for tickets including discount is {0:c}", journey2 - ((journey2 * 15) / 100));
                    }
                    break;

                /************Case 3 Here********/
                default:
                    Console.WriteLine("Invalid selection, Please pick from 1 or 2 only. \nPlease press Enter to quit the program and relaunch to try again.");
                    break;
            }
            Console.ReadLine(); // This is required - saves typing it in 3 times at the end of each case in the switch.
        }
    }
}