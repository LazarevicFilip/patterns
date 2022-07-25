using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using design_patterns.Strategy.Behaviour.Fly;
using design_patterns.Strategy.Behaviour.Quack;
namespace design_patterns.Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.flyBehaviour = new FlyNoWay();
            this.quackBehaviour = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("Model duck...");
        }
    }
}
