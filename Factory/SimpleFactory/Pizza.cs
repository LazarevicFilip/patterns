using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.SimpleFactory
{
    public interface Pizza
    {
        public void prepare();
        public void bake();
        public void cut();
        public void box();
    }
}
