using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    class Mage : Enemy
    {
        public Mage(int x, int y): base(x, y, 5, 5)
        {

        }
        public override Movement ReturnMove(Movement mOVEMENT = Movement.NO_MOVEMENT)
        {
            return Movement.NO_MOVEMENT;
        }
        public override bool CheckRange(Character target)
        {
           

            for (int nx = 0; nx <= 1; nx++)
            {
                for (int ny = 0; ny <= 1; ny++)
                {
                    if (nx == 0 && ny ==0)
                    {
                        continue;//skips the rest of the current ireration of the loop
                    }
                    //target imn range
                    if (x + nx == target.X && y +ny == target.Y)
                    {
                        return true;
                    }
                }
            }//target not in range
            return false;

        }
    }
}
