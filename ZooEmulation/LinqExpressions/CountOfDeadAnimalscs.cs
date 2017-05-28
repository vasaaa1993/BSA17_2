using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class CountOfDeadAnimalscs : BaseExpression
	{
		public CountOfDeadAnimalscs(List<Animal> animals) : base("7", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			var arr = _aAnimals.GroupBy(an => an.GetType())
				.Select(gr => (Type: gr.Key.Name, Count: gr.Count()));
			Console.WriteLine();
			if(!IsEmptyCW(arr))
			{
				foreach(var item in arr)
					Console.WriteLine($"{item.Type} - {item.Count}");
			}
			Console.WriteLine();
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Show count of dead animals of each existing types";
		}
	}
}
