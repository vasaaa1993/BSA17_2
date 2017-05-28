using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
using ZooEmulation.LinqExpressions;
namespace ZooEmulation.Commands
{
	class CommandLINQ : CommandAnimal
	{
		readonly List<BaseExpression> _aExpersions;
		public CommandLINQ(List<Animal> animals) : base("linq", animals)
		{
			_aExpersions = new List<BaseExpression>();
			_aExpersions.AddRange(
				new BaseExpression[] {
					new AllSickTiger(_aAnimals),
					new AverrageHealth(_aAnimals),
					new BearsAndWolfs(_aAnimals),
					new ElephantByAlias(_aAnimals),
					new AliasesOfHungryAnimals(_aAnimals),
					new AnimalsByState(_aAnimals),
					new CountOfDeadAnimalscs(_aAnimals),
					new GroupByType(_aAnimals),
					new HealthiestAnimalsByType(_aAnimals),
					new MinMaxHealthAnimal(_aAnimals)
				});
		}

		public override CommandsReturn Execute(string[] parameters)
		{
			if (parameters.Length < 1)
				return CommandsReturn.CR_INVALID_ARGS;

			CommandsReturn rez = CommandsReturn.CR_ALL_RIGHT;
			foreach (var ex in _aExpersions)
			{
				if (ex.CallString == parameters[0])
				{
					List<string> arr = new List<string>();
					arr.AddRange(parameters);
					arr.RemoveAt(0);
					if (ex.ExecuteAndShow(arr.ToArray()) != 0)
						rez = CommandsReturn.CR_INVALID_ARGS;
					break;
				}	
			}
			return rez;
		}

		public override string ToString()
		{
			StringBuilder sBuild = new StringBuilder();
			sBuild.AppendLine($"{base.ToString()} <linq command nump> [parameters]");
			foreach(var ex in _aExpersions)
				sBuild.AppendLine($"\t{ex}");
			return sBuild.ToString();
		}
	}
}
