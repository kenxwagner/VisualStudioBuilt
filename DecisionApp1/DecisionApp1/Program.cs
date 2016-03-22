using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for minutes exercised
            Console.Write("Enter the minutes exercised: ");

            string entry = Console.ReadLine();

            //Console.Write(entry);


            //Add minutes exercised to total
            //Display total minutes exercised to screen

            Console.WriteLine("You've entered " + entry + " minutes");
            //Repeat until user quits
        }
    }
}
