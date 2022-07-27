using Factory.AbstractFactory.Ingrediens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    public class CHPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            throw new NotImplementedException();
        }

        public Clams createClams()
        {
            throw new NotImplementedException();
        }

        public Dough createDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni createPepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce createSauce()
        {
            throw new NotImplementedException();
        }

        public Veggies[] createVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
