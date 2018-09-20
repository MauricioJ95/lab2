using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DateTime result, result1;
                Console.WriteLine("Enter a valid datetime");
                string d1 = Console.ReadLine();

                if (!System.DateTime.TryParse(d1, out result))
                {
                    Console.WriteLine("Please enter a valid date");
                    Console.ReadLine();
                }
                
                Console.WriteLine("Enter a valid datetime");
                string d2 = Console.ReadLine();

                if (!System.DateTime.TryParse(d2, out result1))
                {
                    Console.WriteLine("Please enter a valid date");
                    Console.ReadLine();
                }
                string output;

                

                var difference = result - result1;

                

                output = "Difference in dates is " + difference.Days + " days, " + difference.Hours + " hours, " + difference.Minutes + " Minutes.";
                Console.WriteLine(output);
                Console.ReadLine();

               



            }
        }
    }
}

