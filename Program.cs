using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimenting
{
    class Program
    {
        string userFirstName = "";
        string userLastName, userFavColor, userAgeString, userBirthMonthString, userSiblingsString;
        int userAgeInt, userBirthMonthInt, userSiblingsInt, numberOfYears; 

        public void acceptUserData()
        {
            Console.WriteLine("\nWhat is your first name?");
            userFirstName = Console.ReadLine();
            userQuitInput(userFirstName);

            Console.WriteLine("\nWhat is your last name?");
            userLastName = Console.ReadLine();
            userQuitInput(userLastName);

            
            Console.WriteLine("\nHow old are you?");
            userAgeString = Console.ReadLine();
            userAgeInt = int.Parse(userAgeString);
            //userQuitInput(userAgeInt.ToString());

            Console.WriteLine("\nWhat month were you born (as a numeral)?");
            userBirthMonthString = Console.ReadLine();
            userBirthMonthInt = int.Parse(userBirthMonthString);
            //userQuitInput(userBirthMonthString);
            

            Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
            userFavColor = Console.ReadLine();
            userQuitInput(userFavColor);
            userFavColor = colorHelpMenu(userFavColor);

            Console.WriteLine("\nHow many siblings do you have?");
            userSiblingsString = Console.ReadLine();
            userSiblingsInt = int.Parse(userSiblingsString);
            //userQuitInput(userSiblingsString);
        }
        
        public void userQuitInput(string quit)
        {
            quit = quit.ToUpper();
            if (quit == "QUIT")
            {
                Environment.Exit(0);
                //Console.WriteLine("Quit worked");
            }
        }

        public string colorHelpMenu(string color)
        {
            string helpTest;

            helpTest = color.ToUpper();
            while (helpTest == "HELP")
            {
                Console.WriteLine("\nYour Color Options are:");
                Console.WriteLine("\tRed \n\tOrange \n\tYellow \n\tGreen \n\tBlue \n\tIndigo \n\tViolet");
                Console.WriteLine("\nWhat is your favorite ROYGBIV color (enter \"Help\" for the list of colors)?");
                color = Console.ReadLine();
                helpTest = color.ToUpper();
                
            }
            return color;   
        }

        public void userAgeEvenOddCalc()
        {
            int evenRetYear = 30;
            int oddRetYear = 25;

            if (userAgeInt % 2 == 0)
            {
                numberOfYears = evenRetYear;
            }
            else
            {
                numberOfYears = oddRetYear;
            }
        }

        /*
        public string userColor2ModeOfTransport()
        {
            return;
        }
        */

        static void Main(string[] args)
        {
            Program p = new Program();
            while(true)
            {
                Console.WriteLine("Welcome\nLet's see into your future.");
                p.acceptUserData();
                Console.WriteLine("test" + p.userFirstName);
                Console.WriteLine("test" + p.userLastName);
                Console.WriteLine("test" + p.userFavColor);
                Console.WriteLine("test" + p.userAgeInt);
                Console.WriteLine("test" + p.userBirthMonthInt);
                Console.WriteLine("test" + p.userSiblingsInt);
                Console.ReadKey();
            }
        }
    }
}
