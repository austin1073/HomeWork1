using System;

//Austin Hyer
//1-18-2023
//This program simulates rolling two dice a given number of times. It asks the user for the number of rolls and then displays the distribution
//of the dice rolls in a histogram-esque output.
namespace HomeWork1
{
    public class Program
    { 

        public static void Main(string[] args)
        {
            //Welcome the user to the program and asks how many dice they would like to roll.
            Console.WriteLine("Welcome to the dice thowing simulator!");
            string numRollStr = "";
            Console.Write("\nHow many dice rolls would you like to simulate?  ");
            numRollStr = Console.ReadLine();
            int numRoll;
            numRoll = Convert.ToInt32(numRollStr);
            //Delcaring the array that will hold all our rolls - counts how many 2s, 3s, 4s, etc.
            int[] counts = new int[11];

            //For loop that simulates rolling two dice x amount of times.
            for (int i = 0; i < numRoll; i++)
            {
                var random = new Random();
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;
                //Switch statement that keeps track of each total
                switch(sum)
                {
                    case 2:
                        counts[0]++;
                        break;
                    case 3:
                        counts[1]++;
                        break;
                    case 4:
                        counts[2]++;
                        break;
                    case 5:
                        counts[3]++;
                        break;
                    case 6:
                        counts[4]++;
                        break;
                    case 7:
                        counts[5]++;
                        break;
                    case 8:
                        counts[6]++;
                        break;
                    case 9:
                        counts[7]++;
                        break;
                    case 10:
                        counts[8]++;
                        break;
                    case 11:
                        counts[9]++;
                        break;
                    case 12:
                        counts[10]++;
                        break;
                }
            }
            //Adds up how many rolls where done - could just use the give number from the user as well.
            int total;
            total = counts[0] + counts[1] + counts[2] + counts[3] + counts[4] + counts[5] + counts[6] + counts[7] + counts[8] + counts[9] + counts[10];
            
            //Outputs the results in a histogram-esque manner.
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRoll);
            Console.Write("\n2: ");
            Class1.Stars(counts[0] * 100 / total);
            Console.Write("3: ");
            Class1.Stars(counts[1] * 100 / total);
            Console.Write("4: ");
            Class1.Stars(counts[2] * 100 / total);
            Console.Write("5: ");
            Class1.Stars(counts[3] * 100 / total);
            Console.Write("6: ");
            Class1.Stars(counts[4] * 100 / total);
            Console.Write("7: ");
            Class1.Stars(counts[5] * 100 / total);
            Console.Write("8: ");
            Class1.Stars(counts[6] * 100 / total);
            Console.Write("9: ");
            Class1.Stars(counts[7] * 100 / total);
            Console.Write("10: ");
            Class1.Stars(counts[8] * 100 / total);
            Console.Write("11: ");
            Class1.Stars(counts[9] * 100 / total);
            Console.Write("12: ");
            Class1.Stars(counts[10] * 100 / total);
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
