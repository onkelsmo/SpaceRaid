using SpaceRaid.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRaid.Elements.Events
{
    class Escape : Event
    {
        public Escape()
        {
            
        }

        public override void influenceRaider(Raider raider)
        {
            Logger.log("Escape Event triggert \n");
            Logger.log("Tile is the Escape\n");
        }
    }
}
