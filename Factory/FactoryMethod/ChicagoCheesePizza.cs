using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class ChicagoCheesePizza : Pizza
    {

        public override string Name => "CH Cheese Pizza";

        public override string Dough => "Extra Thick Crust Dough";

        public override string Sauce => "Plum Tomato Sauce";

        public override IEnumerable<string> Toppings => new List<string> { "Shredded Mozzarella Cheese" };

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
