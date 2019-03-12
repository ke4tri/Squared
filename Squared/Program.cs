using System;
using System.Collections.Generic;

namespace Squared
{
    class Program
    {
        static void Main(string[] args)
        {
            var randNums = new RandomNums();
            int amount = 20;
            var numbers = randNums.NoShit(amount);
            
            Console.WriteLine("This is a random string of 20 numbers");
            Console.WriteLine(String.Join(" ", numbers));
            Console.WriteLine("This is the random string list squard");
            foreach (int item in numbers)
            {
                var itemToMultiply = item * item;
                
                Console.Write(itemToMultiply + " ");
            }

            Console.ReadLine();
        }
    }
}
            


            
            
            




            
            


            
            








