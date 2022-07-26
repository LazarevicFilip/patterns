using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater.ConcreteCondiments
{
    public class Mocha : Condiment
    {
        private Beverage _bevarge;

        public Mocha(Beverage bevarge)
        {
            _bevarge = bevarge;
        }

        protected override string Description => "Mocha";

        public override decimal cost()
        {
            return _bevarge.cost() + 0.2m;
        }

        public override string getDescription()
        {
           return _bevarge.getDescription() + this.Description;
        }
    }
}
