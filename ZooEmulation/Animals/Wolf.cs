using System;
using System.Collections.Generic;
using System.Text;

namespace ZooEmulation.Animals
{
    class Wolf : Animal
    {
        public Wolf(string sAlias) : base(4, sAlias)
        {
            Health = _nMaxHealth;
        }
    }
}
