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

        /// <summary>
        /// create and establish an array of random events
        /// </summary>
        /// <param name="size"></param>
        public EventFactory(int size)
        {
            this.maxEvents = size;
            this.allowedEvents = new Event[] { new Positiv(), new Negativ(), new Empty() };
            this.eventArray = new Event[size];
            this.fillEventArray();
        }

        /// <summary>
        /// fillEventArray
        /// The EventArray gets filled with Events from the allowedEvents Pool
        /// </summary>
        private void fillEventArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < this.maxEvents; i++)
            {
                int r = rnd.Next(this.allowedEvents.Length);
                this.eventArray[i] = this.allowedEvents[r];
            }
            // Put the Escape on a random location
            int r1 = rnd.Next(this.eventArray.Length);
            this.eventArray[r1] = new Escape();
        }

        /// <summary>
        /// getEvent
        /// </summary>
        /// <returns>array</returns>
        public Event getEvent()
        {
            int counter = this.eventCounter;
            this.eventCounter++;
            return this.eventArray[counter];
        }
    }
}
