﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADES2
{
    [Serializable]
    class Obstacle : Tile
    {
        public Obstacle(int x, int y) : base(x,y, TILETYPE.obstacle)
        {

        }
    }
}