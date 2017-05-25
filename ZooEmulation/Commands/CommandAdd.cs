using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
using ZooEmulation.Creators;
namespace ZooEmulation.Commands
{
	class CommandAdd : CommandAnimal
	{
		private AnimalProviderFactory _animalFactory;
		public CommandAdd(List<Animal> animals):base("add", animals)
		{
			_animalFactory = new AnimalProviderFactory();
		}
		// add, (kind of animal, Alias)
		public override CommandsReturn Execute(string[] parameters)
		{
			CommandsReturn rez = CommandsReturn.CR_ALL_RIGHT;
			if (parameters.Length != 2)
				return CommandsReturn.CR_INVALID_ARGS;
			int nIndex = _aAnimals.FindIndexByAlias(parameters[1]);
			if (nIndex != -1)
				return CommandsReturn.CR_OlREADY_EXIST;
			Animal an = _animalFactory.CreateAnimal(parameters[0].ToLower(), parameters[1]);

			if (an == null)
				rez = CommandsReturn.CR_UNKNOWN_ANIMAL_TYPE;
			else
				_aAnimals.Add(an);
			return rez;
		}

		public override string ToString()
		{
			return (base.ToString() + " <AnimalType> <Alias>\n\r	AnimalType - can write full or short (fox or f)");
		}
	}
}
