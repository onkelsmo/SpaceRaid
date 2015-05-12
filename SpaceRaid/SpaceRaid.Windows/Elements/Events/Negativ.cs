using SpaceRaid.Common;

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
            if (raider.getHp() > 0)
            {
                raider.setHp(raider.getHp() - 1);
                Logger.log("Raider HP -1\n");
            }
            else
            {
                Logger.log("Raider destroyed!");
            }
        }
    }
}
