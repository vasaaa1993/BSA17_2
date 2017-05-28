using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class AverrageHealth : BaseExpression
	{
		public AverrageHealth(List<Animal> animals) : base("10", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			var rez = _aAnimals.Average(an => an.Health);
			Console.WriteLine();
			Console.WriteLine("{0:0.000}", rez);
			Console.WriteLine();
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Show averrage health of all animals in the zoo";
		}
	}
}
