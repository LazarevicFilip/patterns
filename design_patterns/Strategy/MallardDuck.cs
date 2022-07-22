using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackBehaviour = new Quack();
            this.flyBehaviour = new FlyWithWings();
           
        }
        public override void Display()
        {
            Console.WriteLine("Mallard Duck...");
        }
    }
}
