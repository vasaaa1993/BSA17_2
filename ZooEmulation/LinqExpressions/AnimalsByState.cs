using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	class AnimalsByState : BaseExpression
	{
		public AnimalsByState(List<Animal> animals) : base("2", animals)
		{
		}

		public override int ExecuteAndShow(params string[] param)
		{
			if (param.Count() != 1 || Enum.TryParse(param[0], out Animal.State st))
				return -1;
			var aAnimalsByState = _aAnimals.Where(an => an.StateOfAnimal == st);

			Console.WriteLine();
			if (!IsEmptyCW(aAnimalsByState))
			{
				foreach (var an in aAnimalsByState)
					Console.WriteLine(an);
			}
			return 0;
		}

		public override string GetHelp()
		{
			StringBuilder sParametesr = new StringBuilder();
			foreach(var name in Enum.GetNames(typeof(Animal.State)))
			{
				if (sParametesr.Length != 0)
					sParametesr.Append("|");
				sParametesr.Append($"{name}");
			}
			return $"'{_sCallString}' - Get animals by state. Parametr - state({sParametesr.ToString()})";
		}
	}
}
