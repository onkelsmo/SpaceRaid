using SpaceRaid.Elements.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRaid.Elements
{
    class EventFactory
    {
        private Event[] eventArray;

        public EventFactory()
        {
            this.eventArray = new Event[] { new Positiv(), new Negativ(), new Empty() };
        }

        public Event getEvent()
        {
            Random rnd = new Random();
            int r = rnd.Next(this.eventArray.Length);

            return this.eventArray[r];
        }
    }
}
