using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    class Shop
    {
        private Weapon[] weaponArray;
        Random rng;
        Hero hero;

        public Shop(Hero hero)
        {
            rng = new Random();
            weaponArray = new Weapon[3];
            for (int i = 0; i < weaponArray.Length; i++)
            {
                weaponArray[i] = RandomWeapon();
            }
        }
        public Weapon RandomWeapon()
        {
            int choice = rng.Next(1, 5);
            if (choice == 1)
            {
                return RangedWeapon.Types.LONGBOW;
            }
            else if (choice == 2)
            {
                return RangedWeapon.Types.RIFLE;
            }
            else if (choice == 3)
            {
                return MeleeWeapon.Types.DAGGER;
            }
            else if (choice == 4)
            {
                return MeleeWeapon.Types.LONGSWORD;
            }
        }
        public bool CanBuy(int Cost)
        {
            if (hero.GoldAmount >= Cost)
            {
                return true;
            }
            else return false;
        }
        public void Buy(int Cost)
        {
            hero.GoldAmount -= Cost;
            return;
        }
        public string DisplayWeapon(int Cost)
        {
            return "Buy " + WeaponType + Cost.ToString();
        }
    }
}
