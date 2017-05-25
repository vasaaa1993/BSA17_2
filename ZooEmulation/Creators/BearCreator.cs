using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.Creators
{
	class BearCreator : AnimalCreator
	{
		public override Animal CreateAnimal(string sAlias)
		{
			return new Bear(sAlias);
		}

		public BearCreator():base("bear", "b") { }
	}

}

