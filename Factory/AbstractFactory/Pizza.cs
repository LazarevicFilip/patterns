using Factory.AbstractFactory.Ingrediens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clams Clam { get; set; }
        public IEnumerable<string> Toppings { get; }

        public abstract void prepare();
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
