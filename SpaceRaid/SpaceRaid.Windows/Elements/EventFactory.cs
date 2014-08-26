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
            eventArray = new Event[] { new Positiv(), new Negativ(), new Empty() };
        }

        public Event getEvent()
        {
            Random rnd = new Random();
            int r = rnd.Next(eventArray.Length);

            return this.eventArray[r];
        }
    }
}
