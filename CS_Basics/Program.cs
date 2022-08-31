using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //My_Strings();
            My_Numbers();
        }

        static void My_Strings()
        {
            //string are words
            /*
             This is 
            a multi line
            comment 
             */
            string your_name = "Fred";
            Console.WriteLine($"Your name is {your_name}");
            Console.WriteLine($"Howdy. What your pet's name?");
            //Console.ReadLine() only takes in strings. So if you take in a number you'll need to cast it to a new data type
            string pets_name = Console.ReadLine();
            Console.WriteLine($"Your pet's name is {pets_name}");
            Console.ReadKey();
        }

        static void My_Numbers()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            //int = whole numbers
            int your_age = 24;
            float your_change = 36543561.3541321f;
            double the_temperature = 110.9;
            decimal really_small_number = 0.356463135183815M;

            Console.WriteLine($"{nameof(your_age)} is a {your_age.GetType()}");
            Console.WriteLine($"{nameof(your_change)} is a {your_change.GetType()}");
            Console.WriteLine($"{nameof(the_temperature)} is a {the_temperature.GetType()}");
            Console.WriteLine($"{nameof(really_small_number)} is a {really_small_number.GetType()}");

            Console.WriteLine(); 

            Console.WriteLine($"{nameof(your_age)} value is {your_age}");
            Console.WriteLine($"{nameof(your_change)} value is {your_change}");
            Console.WriteLine($"{nameof(the_temperature)} value is {the_temperature}");
            Console.WriteLine($"{nameof(really_small_number)} value is {really_small_number}");


            //Floats have 7-point precision. They also require an F after the number
            Console.ReadLine();
        }

    }
}
