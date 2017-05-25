using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
namespace ZooEmulation.Commands
{
	abstract class CommandAnimal : CommandBase
	{
		protected readonly List<Animal> _aAnimals;
		public CommandAnimal(string sCommand, List<Animal> animals) : base(sCommand)
		{
			_aAnimals = animals;
		}
	}
}
