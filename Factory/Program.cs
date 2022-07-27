using Factory.FactoryMethod;
using Factory.SimpleFactory;
using System;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaFactory = new SimplePizzaFactory();
            var pizzaStore = new SimpleFactory.PizzaStore(pizzaFactory);

            //pizzaStore.orderPizza("cheese");

            var nyPizzaStore = new NYPizzaStore();
            var pizza = nyPizzaStore.orderPizza("cheese");
            Console.WriteLine("Pizza: " + pizza.getName());
        }
    }
}
