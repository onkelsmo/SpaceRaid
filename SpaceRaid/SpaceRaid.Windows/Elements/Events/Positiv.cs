using SpaceRaid.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRaid.Elements.Events
{
    class Positiv : Event
    {
        public Positiv()
        {
           
        }

        public override void influenceRaider(Raider raider)
        {
            Logger.log("Positiv Event triggert \n");
            if(raider.getHp() < 5)
            {
                raider.setHp(raider.getHp() + 1);
                Logger.log("Raider HP +1\n");
            }
        }
    }
}
