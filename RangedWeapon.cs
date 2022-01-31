using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    class RangedWeapon : Weapon
    {
        Types RangedWeaponType;
        public RangedWeapon(int damage, int range, int durability, int cost, string weaponType, char symbol, int x, int y, Types RangedWeaponType) : base(damage, range, durability, cost, weaponType, symbol, x, y)
        {
            this.RangedWeaponType = RangedWeaponType;
            if (RangedWeaponType == Types.RIFLE)
            {
                this.weaponType = "Rifle";
                this.damage = 5;
                this.durability = 3;
                this.cost = 7;
                this.range = 3;
            }
            else
            {
                this.weaponType = "Longbow";
                this.damage = 4;
                this.durability = 4;
                this.cost = 6;
                this.range = 2;
            }
            this.Durability = durability;
        }

        override public int Range
        {
            get
            {
                return base.range;
            }
        }

        public enum Types
        {
            RIFLE, LONGBOW
        }
    }
}
