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

    }
}



