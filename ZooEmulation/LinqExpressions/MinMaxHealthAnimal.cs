using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class MinMaxHealthAnimal : BaseExpression
	{
		public MinMaxHealthAnimal(List<Animal> animals) : base("9", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			if (_aAnimals.Count == 0)
			{
				Console.WriteLine(_cEmptyRez);
			}
			else
			{
				var minMax = _aAnimals.Aggregate(
					(
						min: _aAnimals[0],
						max: _aAnimals[0]
					)
					, (acc, a) => (
						acc.min = a.Health < acc.min.Health ? a : acc.min,
						acc.max = a.Health > acc.max.Health ? a : acc.max));
				Console.WriteLine();
				Console.WriteLine($"min - {minMax.min}");
				Console.WriteLine($"max - {minMax.max}");
				Console.WriteLine();
			}
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Show animals with min and max health";
		}
	}
}
