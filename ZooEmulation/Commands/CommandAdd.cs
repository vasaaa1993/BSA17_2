using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.Commands
{
	class CommandAdd : CommandAnimal
	{
		public CommandAdd(List<Animal> animals):base("add", animals)
		{
		}
		// add, (kind of animal, Alias)
		public override CommandsReturn Execute(string[] parameters)
		{
			CommandsReturn rez = CommandsReturn.CR_ALL_RIGHT;
			if (parameters.Length != 2)
				return CommandsReturn.CR_INVALID_ARGS;
			switch(parameters[0].ToLower()) // type
			{
				case "bear":
				case "b":
					_aAnimals.Add(new Bear(parameters[1]));
					break;
				case "elephant":
				case "e":
					_aAnimals.Add(new Elephant(parameters[1]));
					break;
				case "fox":
				case "f":
					_aAnimals.Add(new Fox(parameters[1]));
					break;
				case "lion":
				case "l":
					_aAnimals.Add(new Lion(parameters[1]));
					break;
				case "tiger":
				case "t":
					_aAnimals.Add(new Tiger(parameters[1]));
					break;
				case "wolf":
				case "w":
					_aAnimals.Add(new Wolf(parameters[1]));
					break;
				default:
					rez = CommandsReturn.CR_UNKNOWN_ANIMAL_TYPE;
					break;
			}
			return rez;
		}

		public override string ToString()
		{
			return (base.ToString() + " <AnimalType> <Alias>\n\rAnimalType - can write full or short (fox or f)");
		}
	}
}
