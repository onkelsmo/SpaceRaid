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

        public int getHp()
        {
            return this.hitPoints;
        }
        public void setHp(int value)
        {
            this.hitPoints = value;
        }
        public string getPosition()
        {
            return this.position;
        }
        public void setPosition(string value)
        {
            if (this.isMoveAllowed(value))
            {
                this.position = value;
                this.setCoords(value);
            }
            // TODO: else?
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

        public Raider()
        {
            this.hitPoints = 5;
            this.position = "tileGrid41";
            this.setCoords(this.position);
            this.range = 1;
        }

        public void display(Grid tileGrid)
        {
            this.lastTile = tileGrid;

            tileGrid.Background = new SolidColorBrush(Colors.Tomato);
        }
        
        private bool isMoveAllowed(string value)
        {
            int[] tileNumber = new int[] { Convert.ToInt32(value.Substring(8, 1)), Convert.ToInt32(value.Substring(9, 1)) };

            if (tileNumber[0] == this.coords[0]+1 ||
                tileNumber[0] == this.coords[0]-1 ||
                tileNumber[1] == this.coords[1]+1 ||
                tileNumber[1] == this.coords[1]-1)
            {
                return true;
            }
            return false;
        }
    }
}
