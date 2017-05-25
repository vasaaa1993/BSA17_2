using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.Commands
{
	class CommandsShow : CommandAnimal
	{
		public CommandsShow(List<Animal> animals) : base("show", animals)
		{
		}

		public override CommandsReturn Execute(string[] parameters)
		{
			if (parameters.Length != 1)
				return CommandsReturn.CR_INVALID_ARGS;
			int nIndex = _aAnimals.FindIndexByAlias(parameters[0]);
			if (nIndex == -1)
				return CommandsReturn.CR_ANIMAL_NOT_FOUND;
			Console.WriteLine(_aAnimals[nIndex].ToString());
			return CommandsReturn.CR_ALL_RIGHT;
		}
	}
}
