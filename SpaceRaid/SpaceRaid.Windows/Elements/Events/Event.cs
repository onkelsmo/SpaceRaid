using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRaid.Elements.Events
{
    class Event
    {
        public Event()
        {
                        
        }

        public virtual void influenceRaider(Raider raider)
        {

        }

        public override string ToString()
        {
            // TODO: modifie return value

            return base.ToString();
            //string value = base.ToString();
            //value = value.Substring()
        }
    }
}
