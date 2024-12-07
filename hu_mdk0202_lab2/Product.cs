using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hu_mdk0202_lab2
{
    public class Product : Component
    {
        private string name;

        public Product(string name)
        {
            this.name = name;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
