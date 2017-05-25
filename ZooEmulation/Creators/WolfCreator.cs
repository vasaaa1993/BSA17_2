using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
namespace ZooEmulation.Creators
{
	class WolfCreator : AnimalCreator
	{
		public override Animal CreateAnimal(string sAlias)
		{
			return new Wolf(sAlias);
		}

		public WolfCreator():base("wolf", "w") { }
	}
}
