using Factory.FactoryMethod;
using Factory.SimpleFactory;
using Factory.AbstractFactory;
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

            var nyPizzaStore = new FactoryMethod.NYPizzaStore();
            //var pizza = nyPizzaStore.orderPizza("cheese");
            //Console.WriteLine("Pizza: " + pizza.getName());

            var nyPizzaStore1 = new AbstractFactory.NYPizzaStore();
            var pizza1 = nyPizzaStore1.orderPizza("cheese");
        }
    }
}
