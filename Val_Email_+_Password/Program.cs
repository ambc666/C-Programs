using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net.Mail;

namespace Val_Email___Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string PassWord = "";
            string CpassWord = "";
            string[] letterCap = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" }; // Arrays
            string[] letterSmall = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", };
            string[] num = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please Enter a Password: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Please enter a password with at least 8 characters");  //Instructions text on console
            Console.WriteLine("2. Must contain at least 1 character lowercase");
            Console.WriteLine("3. Must contain at least 1 character uppercase");
            Console.WriteLine("4. Must also contain a number");

            Console.ForegroundColor = ConsoleColor.White;
            PassWord = Console.ReadLine();

            char[] Pass = PassWord.ToArray();

            int strNumber;
            int CantL = 0; //Lower case variable
            int CantU = 0; //Upper case variable
            int CantN = 0; //Number variable

            for (strNumber = 0; strNumber < letterCap.Length; strNumber++) // Uppercase
            {
                for (int strNumber2 = 0; strNumber2 < Pass.Length; strNumber2++)
                {
                    if (Convert.ToString(Pass[strNumber2]) == letterCap[strNumber])
                        CantU++;
                }
            }
            for (strNumber = 0; strNumber < letterSmall.Length; strNumber++) //Lowercase
            {
                for (int strNumber2 = 0; strNumber2 < Pass.Length; strNumber2++)
                {
                    if (Convert.ToString(Pass[strNumber2]) == letterSmall[strNumber])
                        CantL++;
                }
            }
            for (strNumber = 0; strNumber < num.Length; strNumber++) //Number string
            {
                for (int strNumber2 = 0; strNumber2 < Pass.Length; strNumber2++)
                {
                    if (Convert.ToString(Pass[strNumber2]) == num[strNumber])
                        CantN++;
                }
            }

            if (Convert.ToDecimal(PassWord.Length) < 8)
            {
                Console.WriteLine("1) The quantity of characters is {0} it must be at least 8 characters", PassWord.Length);  //Error instructions if fails for why it has failed.
            }
            if (CantL == 0)
            {
                Console.WriteLine("2)The password must contain at least 1 Lower case");
            }
            if (CantU == 0)
            {
                Console.WriteLine("3)The password must contain at least 1 Upper case");
            }
            if (CantN == 0)
            {
                Console.WriteLine("4)The password must contain at least a number");
            }

            if ((CantL == 0) || (CantU == 0) || (CantN == 0) || (Convert.ToDecimal(PassWord.Length) < 8)) //Logic operators for OR so that they all match or one of them fails, so it gives error to which one
            {
                Console.WriteLine("Please close the program and try again!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Password meets all requirements. Press Enter to continue.");
                Console.ReadLine();

                Console.WriteLine("Write your password again:"); //This only occurs if the Logic passes

                CpassWord = Console.ReadLine();
                if (PassWord == CpassWord)
                {
                    Console.WriteLine("Password match confirmed");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Password entered does not match please close the program and try again!");
                    Console.ReadLine();
                }
            }



            Console.ForegroundColor = ConsoleColor.White; // Makes this white, required incase it loops an error so it stays white.
            Console.WriteLine("Please enter email address: ");
            string eMail = Console.ReadLine();

            if (validEmail(eMail))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Email address is valid!");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green; //Error message is wrote in green
                Console.WriteLine("Email address is not valid.  Please close the program and try again.");
                Console.ReadLine();
            }
        }

        private static bool validEmail(string eMail) //This uses system.net.mail for its syntax which saves me using regex for email validation
        {
            try
            {
                MailAddress mail = new MailAddress(eMail);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        static void passWord(string[] args)
        {
            Console.ReadLine();

            /*  This program asks for a password to be entered and it must meet the requirements it asks for then continues on and asks for a valid email address to be entered.
             *  If the wrong password or email is entered then it asks to close the console and start again.*/
        }
    }
}
