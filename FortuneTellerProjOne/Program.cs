using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProjOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName;
            string lName;
            string color;
            string vacaHome = "null";       //had to assign three variables becuase the compiler wasn't understanding the declaration of variables ran through the if statements
            string vehicle = "null";
            int age;
            int birthMonth;
            int siblings;
            int retire;
            double money = 0.00;

            //I like using \n to format the output in command prompt so it isnt cluttered but I can stop doing it if it is annoying when grading.
            Console.WriteLine("Hello, welcome to fortune teller.  I need to ask a few questions.");
            Console.WriteLine("\nWhat is your First Name? ");
            fName = Console.ReadLine();
            Console.WriteLine("\nThank you " + fName + ". What is your last name? ");
            lName = Console.ReadLine();
            Console.WriteLine("\nAnd your age?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCan I also have your birth month as a number?");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("\nFinally, what is your favorite color? (choose from ROYGBIV type 'help' for more info.");
            color = Console.ReadLine().ToLower();
             if (color == "help")
             {
                Console.WriteLine("R = RED, O = ORANGE, Y = YELLOW, G = GREEN B = BLUE, I = INDIGO, V = VIOLET, Try again... ");
                color = Console.ReadLine().ToLower();
            }
           
            Console.WriteLine("\nGreat Choice!");
             
            Console.WriteLine("\nHow many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());
            // End of user input 
            // Start of logical requirements
            retire = birthMonth % 2; // this calculates even or odd
            if (retire == 0)
            { //even
                retire = retire + 20;
            }
            else //odd
            {
                retire = retire + 29;
            }

            if (siblings < 0)
            {
                vacaHome = "Detriot";
            }
            else if (siblings == 0)
            {
                vacaHome = "Hawaii";
            }
            else if (siblings == 1)
            {
                vacaHome = "Florida";
            } 
            else if (siblings == 2)
            {
                vacaHome = "Texas";
            }
            else if (siblings == 3)
            {
                vacaHome = "Montana";
            }
            else if (siblings > 3)
            {
                vacaHome = "Australia";
            }

            switch(color)
            {
                case "red":
                    vehicle = "sports car";
                    break;

                case "orange":
                    vehicle = "helicopter";
                    break;

                case "yellow":
                    vehicle = "bike";
                    break;

                case "green":
                    vehicle = "jet ski";
                    break;

                case "blue":
                    vehicle = "scooter";
                    break;

                case "indigo":
                    vehicle = "mini van";
                    break;

                case "violet":
                    vehicle = "horse";
                    break;
            }

            if ((birthMonth >= 1) && (birthMonth <= 4)) {
                money = 200000.00;

            } else if ((birthMonth >= 5) && (birthMonth <=8))
            {
                money = 500000.00;

            } else if ((birthMonth >= 9) && (birthMonth <=12))
            {
                money = 1000000.00;

            } else if((birthMonth < 1) || (birthMonth > 12))
            {
                money = 0.00;
            }
         

            // Final Input
            Console.WriteLine("\n" + fName + " " + lName + " will retire in " + retire + " years, with ${0:0.00} in the bank, \na vacation home in " + vacaHome + " and a " + vehicle + ".\n", money);

            //  I had to use indexing for money to keep the format "0.00" even though I know concatnation was in the instructions so most variables are








        }
    }
}
