﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodImplementation
{
    internal class StoreManager : IStoreManager
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
    }
}