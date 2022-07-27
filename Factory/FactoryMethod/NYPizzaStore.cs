using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            if (type == "cheese")
                return new NYCheesePizza();
            else if (type == "vegie")
                return new NYVegiePizza();
            return null;
        }
    }
}
