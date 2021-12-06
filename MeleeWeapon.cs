using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    class MeleeWeapon : Weapon
    {
        public enum Types
        {
            LONGSWORD,DAGGER
        }
        public override int Range 
        { 
            get => base.Range; 
            set => base.Range = 1; 
        }
        public MeleeWeapon(int x, int y, Types type) : base(0,0,0,0,"") //**
        {
            if (type == Types.DAGGER)
            {
                this.damage = 3;
                this.range = 1;
                this.durability = 10;
                this.cost = 3;
            }
            else if (type == Types.LONGSWORD)
            {
                this.damage = 4;
                this.range = 1;
                this.durability = 6;
                this.cost = 5;
            }
        }
    }
}
