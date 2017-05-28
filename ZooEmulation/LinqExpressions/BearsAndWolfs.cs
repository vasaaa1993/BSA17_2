using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class BearsAndWolfs : BaseExpression
	{
		public BearsAndWolfs(List<Animal> animals) : base("8", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			var arr = _aAnimals.Where(an => an.Health > 3 && (an.GetType() == typeof(Bear) || an.GetType() == typeof(Wolf)));
			Console.WriteLine();
			if (!IsEmptyCW(arr))
			{
				foreach (var item in arr)
					Console.WriteLine(item);
			}
			Console.WriteLine();
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Show bears and wolfs in which helth more than 3";
		}
	}
}
