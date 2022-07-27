using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory factory = new NYPizzaIngredientFactory();
            if (type == "cheese")
            {
                pizza = new CheesePizza(factory);
                pizza.Name = "NY style cheese pizza";
            }
            else if (type == "vegie")
            {
                pizza = new VegiePizza(factory);
                pizza.Name = "NY style vegie pizza";
            }
                
            return pizza;
        }
    }
}
