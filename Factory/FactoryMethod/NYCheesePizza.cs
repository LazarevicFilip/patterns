using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class NYCheesePizza : Pizza
    {
        public override string Name => "NY Cheese Pizza";

        public override string Dough => "Thin Crust Dough";

        public override string Sauce => "Marinara Sauce";

        public override IEnumerable<string> Toppings => new List<string> { "Grated Reggiano Cheese" };
       
    }
}
