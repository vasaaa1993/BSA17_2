using System;
using System.Collections.Generic;
using System.Text;

namespace ZooEmulation
{
    class Tiger : Animal
    {
        public Tiger(string sAlias) : base(4, sAlias)
        {
            Health = _nMaxHealth;
        }
    }
}
