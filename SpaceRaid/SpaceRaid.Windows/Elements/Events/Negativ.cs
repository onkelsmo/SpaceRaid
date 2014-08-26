using SpaceRaid.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRaid.Elements.Events
{
    class Negativ : Event
    {
        public Negativ()
        {
            
        }

        public override void influenceRaider(SpaceRaid.Elements.Raider raider)
        {
            Logger.log("Negative Event triggert \n");
            if (raider.getHp() >= 0)
            {
                raider.setHp(raider.getHp() - 1);
                Logger.log("Raider HP -1\n");
            }
            
        }
    }
}
