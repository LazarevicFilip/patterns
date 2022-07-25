using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subjects
{
    public interface Subject
    {
        public void register(ObserverInterface o);
        public void remove(ObserverInterface o);
        public void notifyObservers();
    }
}
