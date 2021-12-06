using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
   abstract class Weapon : Item 
    {

        char Symbol;
        protected Weapon(int damage, int range, int durability, int cost,  string weaponType, char symbol, int x, int y) : base(0,0)
        {
            this.range = range;
            this.durability = durability;
            Durability = durability;
            this.cost = cost;
            Cost = cost;
            this.weaponType = weaponType;
            this.x = x;
            this.y = y;
            this.Symbol = symbol;
        }

        protected int damage;
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        protected int range;

        virtual public int Range
        {
            get
            {
                return Range;
            }
        }

        protected int durability;
        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        protected int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        protected string weaponType;
        public override string ToString()
        {
            string str = Symbol.ToString();
            return str;
        }
    }
}
