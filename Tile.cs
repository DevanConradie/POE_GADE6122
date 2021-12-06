using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    public abstract class Tile
    {
        protected int x;
        protected TILETYPE tileType; 
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public TILETYPE TileType
        {
            get { return tileType; }
            set { tileType = value; }
        }
        public Tile(int x, int y, TILETYPE tileType)
        {
            this.x = x;
            this.y = y;
            this.tileType = tileType;
        }
        public enum TILETYPE
        {
            hero, enemy, obstacle,emptyTile,
            goblin, mage, weapon,
            gold, item,leader,dagger, longsword,bow
        }

       


    }
}
