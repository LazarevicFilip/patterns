using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace design_patterns.Strategy
{
    public abstract class Duck
    {
        public FlyBehaviour flyBehaviour;
        public QuackBehaviour quackBehaviour;

        public Duck()
        {

        }
        public void Swim()
        {
            Console.WriteLine("Swiming...");
        }
  
        public void preformFly()
        {
            //duck obj delegates behaviour to the object that is referenced by instance variable in runtime to preform behaviour
            flyBehaviour.Fly();
        }
        public void preformQuack()
        {
            quackBehaviour.Quack();
        }
        public void setFlyBehaviour(FlyBehaviour fb)
        {
            this.flyBehaviour = fb;
        }
        public void setQuackBehaviour(QuackBehaviour qb)
        {
            this.quackBehaviour = qb;
        }
        public abstract void Display();
    }
}
