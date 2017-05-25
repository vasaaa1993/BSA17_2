using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooEmulation.Animals;
namespace ZooEmulation.Creators
{
	class AnimalProviderFactory
	{
		private readonly List<AnimalCreator> _aCreators;

		public AnimalProviderFactory()
		{
			_aCreators = new List<AnimalCreator>();
			_aCreators.AddRange(new AnimalCreator[]
			{
				new BearCreator(),
				new ElephantCreator(),
				new FoxCreator(),
				new LionCreator(),
				new TigerCreator(),
				new WolfCreator()
			});
		}

		public Animal CreateAnimal(string sType, string sAlias)
		{
			Animal rez  = null;
			foreach(AnimalCreator creator in _aCreators)
			{
				if (creator.CallStrings.FindIndex(str => str == sType) != -1)
				{
					rez = creator.CreateAnimal(sAlias);
					break;
				}
			}
			return rez;
		}
	}
}
