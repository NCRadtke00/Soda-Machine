﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Backpack
    {
        public List<Can> backpack;

        public Backpack(Can can)
        {
            AddCansToBackpack(can);
            backpack = new List<Can>();
        }
        public void AddCansToBackpack(Can can)
        {
            backpack.Add(can);
        }
    }
}
