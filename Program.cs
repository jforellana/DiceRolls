using dice;
using System.Collections;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Xml;


internal class Program
{
    private static void Main(string[] args)
    {
        diceroll dr;

        dr = new diceroll();

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
            "How many dice rolls would you like to simulate?");

        // save user input
        int dice = int.Parse(System.Console.ReadLine());

        // send die to rolldie class and store the results in results array
        int[] results = dr.rolldie(dice);

        // output the results
        for (int i = 0; i < results.Length; i++) 
        {
            // convert the number of times each number was rolled into a decimal
            float percent = (float)results[i]/(float)dice;
            // convert float to integer
            int round = (int)(percent*100);

            string output = "";
            output = (i+2)+":\t";

            // create a string of asteriscs for each possible rolldie total
            for (int j = 0; j < round; j++)
            {
                output += "*";
            }

            // output results in console
            System.Console.WriteLine(output);
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}