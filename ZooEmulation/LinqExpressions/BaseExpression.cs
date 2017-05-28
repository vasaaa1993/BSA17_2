using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.LinqExpressions
{
	abstract class BaseExpression
	{
		protected readonly List<Animal> _aAnimals;
		protected readonly string _sCallString;
		protected const string _cEmptyRez = "empty result(";
		public BaseExpression(string sCallStr, List<Animal> animals)
		{
			_sCallString = sCallStr;
			_aAnimals = animals;
		}
		protected bool IsEmpty<T>(IEnumerable<T> arr)
		{
			return arr.Count() == 0;
		}

		protected bool IsEmptyCW<T>(IEnumerable<T> arr)
		{
			if (IsEmpty(arr))
			{
				Console.WriteLine(_cEmptyRez);
				return true;
			};
			return false;
		}

		public abstract string GetHelp();
		/// <summary>
		/// return -1 when take invalid params, else return 0
		/// </summary>
		public abstract int ExecuteAndShow(params string[] param);
	
	}
}
