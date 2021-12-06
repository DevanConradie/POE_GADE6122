using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    class RangedWeapon : Weapon
    {
        public enum Types
        {
            LONGBOW,RIFLE
        }
        public override int Range { get => base.Range; set => base.Range = value; }
        public RangedWeapon(int x, int y, Types type) : base(0, 0, 0, 0, "") //**
        {
            if (type == Types.LONGBOW)
            {
                weaponType = "Longbow";
                weaponType.ToString();
                this.damage = 4;
                this.range = 2;
                this.durability = 4;
                this.cost = 6; 
            }
            else if (type == Types.RIFLE)
            {
                weaponType = "Rifle";
                this.damage = 5;
                this.range = 3;
                this.durability = 3;
                this.cost = 7;
            }
        }
    }
}
