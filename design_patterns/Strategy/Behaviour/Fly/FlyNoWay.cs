using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy.Behaviour.Fly
{
    public class FlyNoWay : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly...");
        }
    }
}
