using System;
using System.Collections.Generic;
using System.Text;

namespace ZooEmulation
{
    class Lion: Animal
    {
        public Lion(string sAlias) : base(5, sAlias)
        {
            Health = _nMaxHealth;
        } 
    }
}
