using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_User_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = ("Please enter first name: ");
            Console.WriteLine("{0}", nameFirst);
            nameFirst = (Console.ReadLine());

            string nameSecond = ("Please enter surname name: ");
            Console.WriteLine("{0}", nameSecond);
            nameSecond = (Console.ReadLine());

            nameFirst = nameFirst.Remove(1); //This removes all from nameFirst but 1st Character
            Console.WriteLine("This is the Username: \n{0}", nameFirst + nameSecond);

            Console.ReadLine();

            /*This program runs and takes the first name and second name then
              makes a username with the first initial and surname*/
        }
    }
}
