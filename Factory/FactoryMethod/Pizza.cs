using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public abstract class Pizza
    {
        public abstract string Name { get; }
        public abstract string Dough { get; }
        public abstract string Sauce { get; }
        public abstract IEnumerable<string> Toppings { get; }

        public void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough " + Dough);
            Console.WriteLine("Adding sauce " + Sauce);
            foreach(var top in Toppings)
            {
                Console.WriteLine(top);
            }
        }
        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350C");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizzas into diagonal slices");
        }
        public void box()
        {
            Console.WriteLine("Place pizza in original boxes");
        }
        public string getName()
        {
            return Name;
        }
    }
}
