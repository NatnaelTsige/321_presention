using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodImplementation
{
    internal class FruitSorter
    {
        private IFruit _fruit;

        // Constructor.
        public FruitSorter(IFruit fruit)
        {
            this._fruit = fruit;
        }

        // Just one function for all fruits.
        public void CheckFruit(int num) 
        {
            this._fruit.DisplayInfo(num);
        }
    }
}
