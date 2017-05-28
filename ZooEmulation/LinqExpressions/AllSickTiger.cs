using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class AllSickTiger : BaseExpression
	{
		public AllSickTiger(List<Animal> animals) : base("3", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			var aSickTigers = _aAnimals.Where(an => an.StateOfAnimal == Animal.State.Sick && an.GetType() == typeof(Tiger));
			Console.WriteLine();
			if(!IsEmptyCW(aSickTigers))
			{
				foreach (var an in aSickTigers)
					Console.WriteLine(an);
			}
			Console.WriteLine();
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Show all sick tigers.";
		}
	}
}
