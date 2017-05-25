using System;
using System.Collections.Generic;
using System.Text;

namespace ZooEmulation.Animals
{
    class Lion: Animal
    {
        public Lion(string sAlias) : base(5, sAlias)
        {
            Health = _nMaxHealth;
        } 
    }
}
