using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message

            Console.WriteLine("What is your temperature?");
            const double limit = 38.0;
            const double lowtemp = 35.0;


            while (true)
            {

                // Enter user guess
                Console.WriteLine("Enter Temperature :");
                double temperature = Convert.ToDouble(Console.ReadLine());





                // Compare guess to number
                if (temperature >= limit)
                {
                    Console.WriteLine("Your too hot, you may have coronavirus, get a test to make sure!");


                }
                if (temperature <= lowtemp)
                {
                    Console.WriteLine("You are too cold, you need to warm up")
                }
                else
                {
                    Console.WriteLine("Your ok to go into school!");
                }


            }
        }

        static double InputDouble(string prompt)
        {
            Console.Write(prompt);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;

        }
    }
}