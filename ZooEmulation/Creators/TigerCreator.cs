using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
namespace ZooEmulation.Creators
{
	class TigerCreator : AnimalCreator
	{
		public override Animal CreateAnimal(string sAlias)
		{
			return new Tiger(sAlias);
		}

		public TigerCreator():base("tiger", "t") { }
	}
}
