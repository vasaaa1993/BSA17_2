using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class HealthiestAnimalsByType : BaseExpression
	{
		public HealthiestAnimalsByType(List<Animal> animals) : base("6", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			var aHelthiest = _aAnimals.GroupBy(an => an.GetType()).Select(
				gr => (
				Type:gr.Key.Name, 
				Animal:gr.Aggregate(
					gr.First(), 
					(acc, an) => an.Health > acc.Health ? an : acc)));
			Console.WriteLine();
			if(!IsEmptyCW(aHelthiest))
			{
				foreach (var item in aHelthiest)
					Console.WriteLine($"{item.Type} - {item.Animal}");
			}
			Console.WriteLine();
			return 0;
		}

		public override string GetHelp()
		{
			return $"'{_sCallString}' - Show healthiest animals of each types";
		}
	}
}
