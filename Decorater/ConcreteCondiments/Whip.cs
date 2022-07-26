using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater.ConcreteCondiments
{
    public class Whip : Condiment
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        protected override string Description => "Whip";

        public override decimal cost()
        {
            return _beverage.cost() + 0.1m;
        }
        public override string getDescription()
        {
            return _beverage.getDescription() + Description;
        }
    }
}
