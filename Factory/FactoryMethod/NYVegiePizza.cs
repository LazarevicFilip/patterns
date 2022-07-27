using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class NYVegiePizza : Pizza
    {
        public override string Name => "NY Vegie Pizza";

        public override string Dough => "Thin Crust Dough";

        public override string Sauce => "Onion Sauce";

        public override IEnumerable<string> Toppings => new List<string> { "Ketchap" };

    }
}
