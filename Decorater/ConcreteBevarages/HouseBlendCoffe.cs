using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater.ConcreteBevarages
{
    public class HouseBlendCoffe : Beverage
    {
        protected override string Description => "House Blend Coffee";

        public override decimal cost()
        {
            return 1.05m;
        }
    }
}
