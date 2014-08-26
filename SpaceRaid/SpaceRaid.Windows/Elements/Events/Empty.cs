using SpaceRaid.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRaid.Elements.Events
{
    class Empty : Event
    {
        public Empty()
        {
            
        }

        public override void influenceRaider(Raider raider)
        {
            Logger.log("Empty Event triggert \n");
            Logger.log("Tile is Empty\n");
        }
    }
}
