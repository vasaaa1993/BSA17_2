using System;
using System.Collections.Generic;
using System.Text;

namespace ZooEmulation.Animals
{
    class Elephant : Animal
    {
        public Elephant(string sAlias) : base(7, sAlias)
        {
            Health = _nMaxHealth;
        }
    }
}
