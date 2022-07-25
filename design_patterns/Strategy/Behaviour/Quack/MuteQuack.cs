using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy.Behaviour.Quack
{
    public class MuteQuack : QuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I can't quck...");
        }
    }
}
