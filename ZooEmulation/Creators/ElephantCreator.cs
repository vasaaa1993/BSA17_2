using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
namespace ZooEmulation.Creators
{
	class ElephantCreator : AnimalCreator
	{
		public override Animal CreateAnimal(string sAlias)
		{
			return new Elephant(sAlias);
		}

		public ElephantCreator():base("elephant", "e") { }
	}
}
