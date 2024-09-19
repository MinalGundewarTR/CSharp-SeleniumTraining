using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.CSharpConcept
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("Selenium training Day1!!!");

            string[] ColourArray = new string[3];
            {
                ColourArray[0] = "Red";
                ColourArray[1] = "Green";
                ColourArray[2] = "Yellow";

                Console.WriteLine(ColourArray[0] + " " + ColourArray[1] +" "+ ColourArray[2]);

            }
        }
    }
}
