using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
namespace ZooEmulation.Creators
{
	class LionCreator : AnimalCreator
	{
		public override Animal CreateAnimal(string sAlias)
		{
			return new Lion(sAlias);
		}

		public LionCreator():base("lion", "l") { }
	}
}
