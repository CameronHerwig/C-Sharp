using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.WriteLine("How many hours of sleep did you get?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if(hoursOfSleep>=8)
            {
                Console.WriteLine("You are well rested!");
            }
            else
            {
                Console.WriteLine("You need more sleep!");
            }
        }
    }
}
