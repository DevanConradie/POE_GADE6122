using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    class Shop
    {
        private Weapon[] weaponArray = new Weapon[3];
        Random rng = new Random();
        Hero characterPurchasing;

        public Shop(Hero characterPurchasing)
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
            int choice = rng.Next(1, 4);
            if (choice == 1)
            {
                return new RangedWeapon(0,0,0,0,"Longbow",'B',0,0,RangedWeapon.Types.LONGBOW);
            }
            else if (choice == 2)
            {
                return new RangedWeapon(0, 0, 0, 0, "Rifle", 'R', 0, 0, RangedWeapon.Types.RIFLE);
            }
            else if (choice == 3)
            {
                return new MeleeWeapon(0,0,0,"Dagger",'D',0,0,MeleeWeapon.Types.DAGGER);
            }
            else
            {
                return new MeleeWeapon(0, 0, 0, "Longsword", 'S', 0, 0, MeleeWeapon.Types.LONGSWORD);
            }
            
        }
        public bool CanBuy(int Cost)
        {
            if (characterPurchasing.GoldAmount >= Cost)
            {
                return true;
            }
            else return false;
        }
        public void Buy(int Cost)
        {
            characterPurchasing.UpdateGold(-Cost);
            return;
        }
        public string DisplayWeapon(int Cost)
        {
            return
                "Buy " + weaponArray[0] + Cost.ToString() +
                " Buy " + weaponArray[1] + Cost.ToString() +
                " Buy " + weaponArray[2] + Cost.ToString();
        }
    }
}
