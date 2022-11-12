using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadImplementation
{
    public class Bird 
    {

        public void eat()
        {
            Console.WriteLine("eat some food.");
        }

        public virtual void fly()
        {
            Console.WriteLine("Fly!");
        }
    }
}

