using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApp
{
    class Program
    {
        public static void Power()
        {
            int[] powerballArray = new int[5];
            int powerball;
            var rnd = new Random();

            //For loop to generate five random numbers while using an if statement to check for duplicates and discard them.
            for (int i = 0; i < 5;)
            {
                int temp = rnd.Next(1, 70);
                if (powerballArray.Contains(temp) == false)
                {
                    powerballArray[i] = temp;
                    i++;
                }
            }

            //Sorting the array and generating the Powerball
            Array.Sort(powerballArray);
            powerball = rnd.Next(1, 27);

            //Printing the five white balls and the Powerball
            Console.Write("Five white balls: ");
            foreach (int number in powerballArray)
            {
                Console.Write($"{number} ");
            }

            Console.Write($"Powerball: {powerball}");
        }

        public static void Mega()
        {
            int[] megaArray = new int[5];
            int megaball;
            var rnd = new Random();

            //For loop to generate five random numbers while using an if statement to check for duplicates and discard them.
            for (int i = 0; i < 5;)
            {
                int temp = rnd.Next(1, 71);
                if (megaArray.Contains(temp) == false)
                {
                    megaArray[i] = temp;
                    i++;
                }
            }

            //Sorting the array and generating the Megaball
            Array.Sort(megaArray);
            megaball = rnd.Next(1, 26);

            //Printing the five white balls and the Megaball
            Console.Write("Five white balls: ");
            foreach (int number in megaArray)
            {
                Console.Write($"{number} ");
            }

            Console.Write($"Megaball: {megaball}");
        }

        public static void Keno()
        {
            int[] kenoArray;
            int kenoLength = 0;
            bool intChk = false;
            Random rnd = new Random();

            //Retrieves the amount of numbers the user would like to play and uses a while loop and TryParse to make sure the user inputs an integer from 1 to 10 
            while (intChk == false || kenoLength < 1 || kenoLength > 10)
            {
                Console.Write("How many numbers would you like to play (minimum 1 and maximum 10)? ");
                intChk = int.TryParse(Console.ReadLine(), out kenoLength);
                Console.WriteLine();
            }

            //Sets the array length to the user input
            kenoArray = new int[kenoLength];


            //For loop to generate as many random numbers as the user needs while using an if statement to check for duplicates and discard them.
            for (int i = 0; i < kenoArray.Length;)
            {
                int temp = rnd.Next(1, 80);
                if (kenoArray.Contains(temp) == false)
                {
                    kenoArray[i] = temp;
                    i++;
                }
            }

            //Sorting the array for better readability
            Array.Sort(kenoArray);

            //Printing the Keno numbers
            Console.Write("Your Keno numbers: ");
            foreach (int number in kenoArray)
            {
                Console.Write($"{number} ");
            }

        }

        public static void Lucky()
        {
            int[] luckyArray = new int[5];
            int luckyball;
            var rnd = new Random();

            //For loop to generate five random numbers while using an if statement to check for duplicates and discard them.
            for (int i = 0; i < 5;)
            {
                int temp = rnd.Next(1, 49);
                if (luckyArray.Contains(temp) == false)
                {
                    luckyArray[i] = temp;
                    i++;
                }
            }

            //Sorting the array and generating the Luckyball
            Array.Sort(luckyArray);
            luckyball = rnd.Next(1, 19);

            //Printing the five whiteballs and the Luckyball
            Console.Write("Five white balls: ");
            foreach (int number in luckyArray)
            {
                Console.Write($"{number} ");
            }
            Console.Write($"Luckyball: {luckyball}");
        }

        public static void Pick3()
        {
            int[] pick3Array = new int[3];
            var rnd = new Random();

            //For loop to generate three random numbers.  There is no check for duplicates because numbers can repeat in the Pick 3.
            for (int i = 0; i < 3; i++)
            {
                pick3Array[i] = rnd.Next(0, 10);
            }

            //Sorting the array
            Array.Sort(pick3Array);

            //Printing the three numbers
            Console.Write("Pick 3 numbers: ");
            foreach (int number in pick3Array)
            {
                Console.Write($"{number} ");
            }

        }

        public static void Pick4()
        {
            int[] pick4Array = new int[4];
            var rnd = new Random();

            //For loop to generate four random numbers.  There is no check for duplicates because numbers can repeat in the Pick 4.
            for (int i = 0; i < 4; i++)
            {
                pick4Array[i] = rnd.Next(0, 10);
            }

            //Sorting the array
            Array.Sort(pick4Array);

            //Printing the four numbers
            Console.Write("Pick 4 numbers: ");
            foreach (int number in pick4Array)
            {
                Console.Write($"{number} ");
            }

        }

        static void Main(string[] args)
        {
            //Method tester
            //while (true)
            //{
            //    Lucky();
            //    Console.WriteLine("\n");
            //    Task.Delay(3000).Wait();
            //}

            bool againBool = true, lottoBool = false;
            int selection = 0;
            string yesNo = "";

            //Program is wrapped in a while loop to let the user generate as many sets of numbers as they want.
            while (againBool == true)
            {
                //Asking the user to select a game.  Uses a while loop and TryParse to make sure user inputs an integer between 1 and 6
                while (lottoBool == false || selection < 1 || selection > 6)
                {
                    Console.Write("\n1 Powerball \n2 MegaMillions \n3 Keno \n4 Lucky4Life \n5 Pick 3 \n6 Pick 4 \n\nPlease input an integer from 1 - 6 to select the lottery you would like to play: ");
                    lottoBool = int.TryParse(Console.ReadLine(), out selection);
                    Console.WriteLine("\n");
                }

                //Switch statement to select the game the user wants to play
                switch (selection)
                {
                    case 1:
                        Power();
                        break;
                    case 2:
                        Mega();
                        break;
                    case 3:
                        Keno();
                        break;
                    case 4:
                        Lucky();
                        break;
                    case 5:
                        Pick3();
                        break;
                    case 6:
                        Pick4();
                        break;
                }

                //Asks user if they would like to generate more lotto numbers.  Uses a while loop to get the correct Y or N input.
                while (yesNo != "N" && yesNo != "Y")
                {
                    Console.Write("\n\n\nWould you like to generate more numbers? Input 'Y' for yes or 'N' for no: ");
                    yesNo = Console.ReadLine().ToUpper().TrimStart();//RESEARCH SUBSTRING SO YOU CAN GET THE FIRST LETTER IN CASE USER TYPES YES OR NO INSTEAD OF Y OR N
                    Console.WriteLine("\n");


                    if (yesNo == "N")
                    {
                        againBool = false;
                    }
                    else if (yesNo == "Y")
                    {
                        lottoBool = false;
                        selection = 0;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

                //Resets the yesNo variable so the program will re-enter the yesNo while loop
                yesNo = "";

            }



        }
    }
}
