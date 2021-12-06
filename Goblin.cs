using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x,y,10,1) //base( /*x, y, 10, 1, TILETYPE.goblin*/)
        {
           
        }
        public override Movement ReturnMove(Movement move = Movement.NO_MOVEMENT)
        {
            int moveDir;
            int tries = 10;

                do
            {
                moveDir = random.Next(0, 4);
                tries--;
                if (tries==0)
                {
                    return Movement.NO_MOVEMENT;
                }

            } while (!(Vision[moveDir] is EmptyTile) );
            return (Movement)moveDir;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
