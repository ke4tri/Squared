using System;
using System.Collections.Generic;

namespace Squared
{
    class Program
    {
        static void Main(string[] args)
        {
            var randNums = new RandomNums();
            int amount = 13;
            var numbers = randNums.NoShit(amount);
            Console.WriteLine(String.Join(" ", numbers));
            
            Console.ReadLine();
        }


    }
}







