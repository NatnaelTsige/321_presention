using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodImplementation
{
    internal interface IStoreManager
    {
        public void CheckStock();
        public void Restock();
    }
}
