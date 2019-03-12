using System;
using System.Collections.Generic;
using System.Text;

namespace Squared
{
    class RandomNums
    {
        public List<int> NoShit(int amtOfNumbers)
        {
            var numbers = new List<int>();
            Random rng = new Random();
            for (int i = 0; i < amtOfNumbers; i++)
            {
                var newRandom = rng.Next(amtOfNumbers);

                numbers.Add(newRandom);

            }
            return numbers;
        }

        //public List<int> NoShit(int amtOfNumbers, int squared)
        //{
            
        //    var numbersSquared = new List<int>();
        //    var numbersSquared2 = new List<int>();
        //    Random rng2 = new Random();
        //    for (int i = 0; i < amtOfNumbers; i++)
        //    {
                
        //        var newRandom = rng2.Next(amtOfNumbers);
        //        //var newRandom2 = rng2.Next(amtOfNumbers * amtOfNumbers);
        //        var newRandom2 = newRandom * newRandom;

        //        numbersSquared.Add(newRandom);
        //        numbersSquared2.Add(newRandom2 ^ 2);
        //        Console.WriteLine(numbersSquared2);
        //    }

        //    return numbersSquared;
        //}


    }
}
