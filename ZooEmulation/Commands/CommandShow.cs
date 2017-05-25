using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.Commands
{
	class CommandShow : CommandAnimal
	{
		public CommandShow(List<Animal> animals) : base("show", animals)
		{
		}

		public override CommandsReturn Execute(string[] parameters)
		{
			if (parameters.Length != 1)
				return CommandsReturn.CR_INVALID_ARGS;
			Console.WriteLine("-----");
			if (parameters[0] == "-all")
			{
				if (_aAnimals.Count != 0)
				{
					foreach (Animal am in _aAnimals)
						Console.WriteLine(am.ToString());
				}
				else
				{
					Console.WriteLine("No animals in the zoo(");
				}
			}
			int nIndex = _aAnimals.FindIndexByAlias(parameters[0]);
			if (nIndex == -1)
				return CommandsReturn.CR_ANIMAL_NOT_FOUND;
			Console.WriteLine(_aAnimals[nIndex].ToString());
			Console.WriteLine("-----");
			return CommandsReturn.CR_ALL_RIGHT;
		}

		public override string ToString()
		{
			return (base.ToString() + " <Alias>|all");
		}
	}
}
