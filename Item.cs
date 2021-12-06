using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    abstract class Item : Tile
    {
        public Item(int x, int y): base (x,y, TILETYPE.item)
        {

        }
        public abstract override string ToString();
    }
}
