using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class GetAliasesOfHungryAnimals : BaseExpression
	{
		public GetAliasesOfHungryAnimals(List<Animal> animals) : base("5", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			var aAliasesOfHungryAnimals = _aAnimals.Where(an => an.StateOfAnimal == Animal.State.Hungry).Select(an => an.Alias);
			Console.WriteLine();
			if (!IsEmptyCW(aAliasesOfHungryAnimals))
			{
				foreach(var str in aAliasesOfHungryAnimals)
					Console.WriteLine(str);
			}
			Console.WriteLine();
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Show aliases of hungry animals";
		}
	}
}
