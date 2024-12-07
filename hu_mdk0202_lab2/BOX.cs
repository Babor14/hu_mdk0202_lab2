using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hu_mdk0202_lab2
{
    internal class BOX : Component
    {
        private List<Component> components = new List<Component>();
        private string name;

        public BOX(string name)
        {
            this.name = name;
        }

        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (var component in components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
