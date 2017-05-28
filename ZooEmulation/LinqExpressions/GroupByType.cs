using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class GroupByType : BaseExpression
	{
		public GroupByType(List<Animal> animals) : base("1", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			var aGr = _aAnimals.GroupBy(an => an.GetType());

			Console.WriteLine();
			if (!IsEmptyCW(aGr))
			{
				foreach (var gr in aGr)
				{
					Console.WriteLine(gr.Key.Name);
					foreach (var an in gr)
						Console.WriteLine($"\t{an}");
				}
			}
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Group by animals type.";
		}
	}
}
