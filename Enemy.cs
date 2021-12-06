using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    abstract class Enemy : Character
    {
        protected Random random = new Random();

        public Enemy(int x, int y,int amaxHP, int damage ): base(x, y,TILETYPE.enemy)
        {
            Damage = damage;
            HP = amaxHP;
            maxHP = amaxHP;
        }
        public void EnemiesMove()
        {

        }
        public void EnemiesAttack()
        {

        }
        public override string ToString()
        {
            return GetType() + "at [" + x + y + "](" + Damage + ")";
        }
    }
}
