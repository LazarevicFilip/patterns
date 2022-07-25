using Observer.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    public interface ObserverPullInterface
    {
        public void update(Subject subj);
    }
}
