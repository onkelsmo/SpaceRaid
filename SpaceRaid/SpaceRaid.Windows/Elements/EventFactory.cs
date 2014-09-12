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
        private Event[] allowedEvents;
        private Event[] eventArray;
        private int eventCounter;
        private int maxEvents;

        public EventFactory(int size)
        {
            this.maxEvents = size;
            this.allowedEvents = new Event[] { new Positiv(), new Negativ(), new Empty() };
            this.eventArray = new Event[size];
            this.fillEventArray();
        }

        private void fillEventArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < this.maxEvents; i++)
            {
                int r = rnd.Next(this.allowedEvents.Length);
                this.eventArray[i] = this.allowedEvents[r];
            }
            
            // shuffle the array
            int r1 = rnd.Next(this.eventArray.Length);
            this.eventArray[r1] = new Escape();
        }

        public Event getEvent()
        {
            int counter = this.eventCounter;
            this.eventCounter++;
            return this.eventArray[counter];
        }
    }
}
