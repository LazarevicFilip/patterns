using design_patterns.Strategy;
using System;

namespace design_patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.preformFly();
            duck.preformQuack();

            Duck duck1 = new ModelDuck();
            duck1.preformFly();
            duck1.setFlyBehaviour(new FlyRocketPowered());
            duck1.preformFly();
        }
    }
}
