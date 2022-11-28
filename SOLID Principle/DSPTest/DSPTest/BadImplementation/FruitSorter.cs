using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadImplementation
{
    internal class FruitSorter
    {
        public void CheckApple(int num)
        {
            Apple apple = new Apple(); // Create a new apple.
            apple.NumType(num);
        }
        public void CheckBanana(int num)
        {
            Banana banana = new Banana(); // Create a new banana.
            banana.NumType(num);
        }
    }
}
