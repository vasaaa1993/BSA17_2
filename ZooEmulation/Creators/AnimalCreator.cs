using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;

namespace ZooEmulation.Creators
{
	abstract class AnimalCreator
	{
		private readonly List<string> _aCallStrings;
		public AnimalCreator(params string[] callStrings)
		{
			_aCallStrings = new List<string>();
			_aCallStrings.AddRange(callStrings);
		}
		public List<string> CallStrings
		{
			get
			{
				return _aCallStrings;
			}
		}
		public abstract Animal CreateAnimal(string sAlias);

	}
}
