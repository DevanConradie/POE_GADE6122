using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    class Leader : Enemy
    {
        private Tile leaderTarget;
        public Tile LeaderTarget
        {
            get { return leaderTarget; }
            set { leaderTarget = value; }
        }
        public Leader(int x, int y) : base(x, y, 20, 2)
        {
            this.x = x;
            this.y = y;
        }
        public override Movement ReturnMove(Movement mOVEMENT = Movement.NO_MOVEMENT)
        {
            int moveDir;
            int tries = 10;

            do
            {
                if (LeaderTarget.X > x)
                { 
                    moveDir = -1; 
                }
                else if (LeaderTarget.X < x)
                {
                    moveDir = +1;
                }
                else if (LeaderTarget.Y > y)
                {
                    moveDir = -1;
                }
                else if (LeaderTarget.Y < y)
                {
                    moveDir = 1;
                }
                
                tries--;
                if (tries == 0)
                {
                    return Movement.NO_MOVEMENT;
                }

            } while (!(Vision[moveDir] is EmptyTile));
            return (Movement)moveDir;
        }
    }
}
