using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater.ConcreteBevarages
{
    public class Esspreso : Beverage
    {
        protected override string Description => "Espresso";
        public override decimal cost()
        {
            return 1.19m;
        }
    }
}
