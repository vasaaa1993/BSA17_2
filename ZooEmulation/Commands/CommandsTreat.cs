using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.Commands
{
	class CommandsTreat : CommandAnimal
	{
		public CommandsTreat(List<Animal> animals) : base("treat", animals)
		{
		}

		public override CommandsReturn Execute(string[] parameters)
		{
			if (parameters.Length != 1)
				return CommandsReturn.CR_INVALID_ARGS;
			int nIndex = _aAnimals.FindIndexByAlias(parameters[0]);
			if (nIndex == -1)
				return CommandsReturn.CR_ANIMAL_NOT_FOUND;
			if (_aAnimals[nIndex].StateOfAnimal == Animal.State.Dead)
				return CommandsReturn.CR_ANIMAL_WAS_DEAD;
			_aAnimals[nIndex].Treat();
			return CommandsReturn.CR_ALL_RIGHT;
		}
	}
}
