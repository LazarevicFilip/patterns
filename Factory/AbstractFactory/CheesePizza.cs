using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AbstractFactory
{
    public class CheesePizza : Pizza
    {
        private PizzaIngredientFactory _factory;

        public CheesePizza(PizzaIngredientFactory factory)
        {
            _factory = factory;
        }

        public override void prepare()
        {
            Console.WriteLine(Name);
            Dough = _factory.createDough();
            Sauce = _factory.createSauce();
            Pepperoni = _factory.createPepperoni();
            Clam = _factory.createClams();
            Pepperoni = _factory.createPepperoni();
            Veggies = _factory.createVeggies();

        }
    }
}
