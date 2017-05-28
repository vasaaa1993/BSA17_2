using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class ElephantByAlias : BaseExpression
	{
		public ElephantByAlias(List<Animal> animals) : base("4", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			if(param.Count() != 1)
				return -1;
			var elephantByAlias = _aAnimals.Where(an => an.Alias == param[0] && an.GetType() == typeof(Elephant)).FirstOrDefault();
			Console.WriteLine();
			if(elephantByAlias == null)
			{
				Console.WriteLine(_cEmptyRez);
			}
			else
			{
				Console.WriteLine(elephantByAlias);
			}
			Console.WriteLine();
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Show elephant by alias. Parameter - alias";
		}
	}
}
