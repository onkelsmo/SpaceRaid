using SpaceRaid.Common;
using SpaceRaid.Elements.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace SpaceRaid.Elements
{
    class Raider
    {
        private int hitPoints;
        private string position;
        private int[] coords;
        private int range;
        private Grid lastTile;
        private Grid startTile;
        private string tileName;
        private int tiles;
        private int score;
        private EventFactory eventFactory;

        public int getHp()
        {
            return this.hitPoints;
        }
        public void setHp(int value)
        {
            this.hitPoints = value;
        }
        public int getTiles()
        {
            return this.tiles;
        }
        public int getScore()
        {
            return this.score;
        }
        public int getRange()
        {
            return this.range;
        }
        public int[] getCoords()
        {
            return this.coords;
        }
        private void setCoords(string value)
        {
            this.coords = new int[] { Convert.ToInt32(value.Substring(8, 1)), Convert.ToInt32(value.Substring(9, 1)) };
        }
        public string getPosition()
        {
            return this.position;
        }
        public void setPosition(Grid value)
        {
            this.tileName = value.Name;
            if (this.isMoveAllowed(this.tileName))
            {
                SolidColorBrush currentBackground = value.Background as SolidColorBrush;
                if (currentBackground.Color == new SolidColorBrush(Colors.Transparent).Color)
                {
                    value.Background = new SolidColorBrush(Colors.Black);
                    // TODO: check whats on the new tile
                    this.checkTile(value);
                    this.score++;
                }

                this.position = this.tileName;
                this.setCoords(this.tileName);
                this.lastTile = value;
                this.tiles++;
                this.display(value);
            }
            else
            {
                this.position = this.lastTile.Name;
                this.setCoords(this.lastTile.Name);
                this.display(this.lastTile);
            }
        }
        
        public Raider(Grid startTile)
        {
            this.hitPoints = 5;
            this.range = 1;
            this.tiles = 0;
            this.startTile = startTile;
            this.lastTile = startTile;
            this.setCoords(startTile.Name);
            this.setPosition(startTile);
            this.display(startTile);

            this.eventFactory = new EventFactory();
        }

        private void checkTile(Grid tile)
        {
            // TODO: handle the tile
            Event ev = this.eventFactory.getEvent();
            Logger.log(ev.ToString() + "\n");
        }

        private void display(Grid tileGrid)
        {
            tileGrid.Background = new SolidColorBrush(Colors.Tomato);
        }
        
        private bool isMoveAllowed(string value)
        {
            int[] tileNumber = new int[] { Convert.ToInt32(value.Substring(8, 1)), Convert.ToInt32(value.Substring(9, 1)) };

            // TODO: improve movement when range > 1
            if (tileNumber[0] == this.coords[0] - this.range &&
                tileNumber[1] == this.coords[1] - this.range ||
                tileNumber[0] == this.coords[0] - this.range &&
                tileNumber[1] == this.coords[1] ||
                tileNumber[0] == this.coords[0] - this.range &&
                tileNumber[1] == this.coords[1] + this.range ||
                tileNumber[0] == this.coords[0] &&
                tileNumber[1] == this.coords[1] - this.range ||
                tileNumber[0] == this.coords[0] &&
                tileNumber[1] == this.coords[1] + this.range ||
                tileNumber[0] == this.coords[0] + this.range &&
                tileNumber[1] == this.coords[1] - this.range ||
                tileNumber[0] == this.coords[0] + this.range &&
                tileNumber[1] == this.coords[1] ||
                tileNumber[0] == this.coords[0] + this.range &&
                tileNumber[1] == this.coords[1] + this.range)
            {
                Logger.log("Raider moved to " + this.tileName + "\n");
                return true;
            }
            else if (tileNumber[0] == this.coords[0] &&
                tileNumber[1] == this.coords[1])
            {
                Logger.log("You are on " + this.tileName + "\n");
                return false;
            }
            Logger.log("Move to " + this.tileName + " is not allowed!\n");
            return false;
        }
    }
}
