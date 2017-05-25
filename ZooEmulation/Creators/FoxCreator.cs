using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
namespace ZooEmulation.Creators
{
	class FoxCreator : AnimalCreator
	{
		public override Animal CreateAnimal(string sAlias)
		{
			return new Fox(sAlias);
		}

		public FoxCreator():base("fox", "f") { }
	}
}
