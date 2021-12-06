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

      

        protected Weapon(int damage,  int range, int durability, int cost,  string weaponType) : base(0,0)
        {
            this.range = range;
            this.durability = durability;
            Durability = durability;
            this.cost = cost;
            Cost = cost;
            this.weaponType = weaponType;
        }

        protected int damage;
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        protected int range;
        //2.1 virtual accessor
        public virtual int Range
        {
            get { return range; }
            set { range = value; }
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
        //2.1 Weapon type accessor
        public string WeaponType
        {
            get { return weaponType; }
            set { weaponType = value; }
        }
    }
}
