using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadImplemtation
{
    internal class StoreManager : StoreOwner
    {
        public void CheckStock()
        {
            Console.WriteLine("Current stock of the store includes: ...");
            // Check stock of store!
        }

        public void Restock()
        {
            Console.WriteLine("Items restocked!");
            // Restock stock!
        }

        public void ChangeStock()
        {
            Console.WriteLine("Cannot change stock as manager!");
            // This cannot be implemented from the main interface!
        }
    }
}
