using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    class MeleeWeapon : Weapon
    {
        Types MeleeWeaponType;
        public MeleeWeapon(int damage, int durability, int cost, string weaponType,char symbol, int x, int y, Types MeleeWeaponType) : base(damage, 1, durability, cost, weaponType, symbol, x, y)
        {
            this.MeleeWeaponType = MeleeWeaponType;
            if (MeleeWeaponType == Types.DAGGER)
            {
                this.weaponType = "Dagger";
                this.damage = 3;
                this.durability = 10;
                this.cost = 3;
            }
            else
            {
                this.weaponType = "Longsword";
                this.damage = 4;
                this.durability = 6;
                this.cost = 5;
            }
        }

        override public int Range
        {
            get
            {
                return 1;
            }
        }

        public enum Types
        {
            LONGSWORD,DAGGER
        }
    }
}
