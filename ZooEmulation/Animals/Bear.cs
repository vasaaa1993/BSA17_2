using System;
using System.Collections.Generic;
using System.Text;

namespace ZooEmulation.Animals
{
    class Bear : Animal
    {
        public Bear(string sAlias) : base(6, sAlias)
        {
            Health =_nMaxHealth;
        }
    }
}
