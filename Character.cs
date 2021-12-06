using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    abstract class Character : Tile
    {
        protected int goldAmount;
        public int GoldAmount
        {
           get { return goldAmount; }
            
        }
        public int UpdateGold(int amount)
        {
          return  goldAmount = goldAmount + amount;
        }
        protected int HP;
        public int hp
        {
            get { return HP; }
        }

        protected int maxHP;
        public int MAXhp
        {
            get { return maxHP; }
        }

        protected int Damage;
        public int DAMAGE
        {
            get { return Damage; }
        }

        public Tile[] Vision = new Tile[4];
        
        public enum Movement
        {
            NO_MOVEMENT,UP,DOWN,LEFT,RIGHT
        }
        //Constructor
        public Character(int ax, int ay, TILETYPE aTileType) : base(ax, ay, aTileType)
        {

        }
        //methods
        public virtual void Attack(Character target)
        {
            target.HP = target.HP - Damage;
        }
        public bool IsDead()
        {
            if (HP <= 0)
            {
                return true;
            }
            return false;
        }
        public virtual bool CheckRange(Character target)
        {
            return DistanceTo(target) <= 1;

        }
        private int DistanceTo(Character target)
        {
            return Math.Abs(x - target.x) + Math.Abs(y - target.y);
        }
        public void Move(Movement mOVEMENT)
        {
            switch (mOVEMENT)
            {
                case Movement.UP: y = y + 1; break;
                case Movement.DOWN: y = y - 1; break;
                case Movement.RIGHT: x = x + 1; break;
                case Movement.LEFT : x = x - 1; break;
            }
        }
        public abstract Movement ReturnMove(Movement mOVEMENT = 0);

        public abstract override string ToString();

        //update vison
        //pickup methods

    }
}
