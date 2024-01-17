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

        int dice = int.Parse(System.Console.ReadLine());

        int[] results = dr.rolldie(dice);

        for (int i = 0; i < results.Length; i++)
        {
            float percent = (float)results[i]/(float)dice;
            int round = (int)(percent*100);

            string output = "";
            output = (i+2)+":\t";

            for (int j = 0; j < round; j++)
            {
                output += "*";
            }
            System.Console.WriteLine(output);
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}