using System;
using System.Collections.Generic;
using System.Text;

namespace ZooEmulation
{
    class Fox : Animal
    {
        public Fox(string sAlias) : base(3, sAlias)
        {
            Health = _nMaxHealth;
        }
    }
}
