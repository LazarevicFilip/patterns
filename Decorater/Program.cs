using Decorater.ConcreteBevarages;
using Decorater.ConcreteCondiments;
using System;

namespace Decorater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var beverage = new Esspreso();

            Console.WriteLine(beverage.cost() + " " + beverage.getDescription());

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);

            Console.WriteLine(beverage1.cost() + " " + beverage1.getDescription());

        }
    }
}
