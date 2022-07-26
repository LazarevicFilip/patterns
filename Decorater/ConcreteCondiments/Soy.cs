using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater.ConcreteCondiments
{
    public class Soy : Condiment
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        protected override string Description => "Soy";

        public override decimal cost()
        {
            return _beverage.cost() + 0.12m;
        }
        public override string getDescription()
        {
            return _beverage.getDescription() + Description;
        }
    }
}
