using System;
using System.Collections.Generic;
using System.Text;

//This class holds a method that converts the percentage number to that amount of asteriks.
//For example if you put 6 in the function it will return 6 asteriks and then print those ateriks.
namespace HomeWork1
{
    public static class Class1
    {
        public static void Stars(int number)
        {
            string output = "";
            for (int i=0;i<number;i++)
            {
                output = output + '*';
            }
            Console.WriteLine(output);
        }
    }
}
