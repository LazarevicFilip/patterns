using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorater
{
    public abstract class Beverage
    {
        protected abstract string Description { get; }
        
        public virtual string getDescription()
        {
            return Description;
        }
        public abstract decimal cost();
    }
}
