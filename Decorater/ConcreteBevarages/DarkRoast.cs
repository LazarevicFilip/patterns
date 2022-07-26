using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater.ConcreteBevarages
{
    public class DarkRoast : Beverage
    {
        protected override string Description => "Dark roast coffee";
      
        public override decimal cost()
        {
            return 0.89m;
        }
       
    }
}
