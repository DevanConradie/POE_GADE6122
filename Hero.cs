using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    class Hero : Character
    {
        public Hero(int aX, int aY, int aHP) : base (aX, aY,  TILETYPE.enemy)
        {
            HP = aHP;
            maxHP = aHP;
            Damage = 2;
        }
        public override Movement ReturnMove(Movement move = Movement.NO_MOVEMENT)
        {
            var invalidTiles = new TILETYPE[] { TILETYPE.hero, TILETYPE.obstacle };

            while (1 == 1)
            {
                Random rng = new Random();
                var moveGoblinRandom = (Movement)rng.Next(1, 5);

                switch (moveGoblinRandom)
                {
                    case Movement.UP:
                        if (Array.IndexOf(invalidTiles, Vision[0].TileType) == -1)
                            return moveGoblinRandom;
                        break;
                    case Movement.DOWN:
                        if (Array.IndexOf(invalidTiles, Vision[1].TileType) == -1)
                            return moveGoblinRandom;
                        break;
                    case Movement.RIGHT:
                        if (Array.IndexOf(invalidTiles, Vision[2].TileType) == -1)
                            return moveGoblinRandom;
                        break;
                    case Movement.LEFT:
                        if (Array.IndexOf(invalidTiles, Vision[3].TileType) == -1)
                            return moveGoblinRandom;
                        break;
                    default:
                        return Movement.NO_MOVEMENT;
                }
            }

        }
        public override string ToString()
        {
            return "";
        }
    }

}
