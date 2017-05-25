using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ZooEmulation.Commands;
using ZooEmulation.Animals;

internal static class ListAnimalsExtension
{
	public static int FindIndexByAlias(this List<Animal> arr, string sAlias)
	{
		for (int i = 0; i < arr.Count; i++)
		{
			if (arr[i].Alias == sAlias)
				return i;
		}
		return -1;
	}
}

namespace ZooEmulation
{
    class Zoo
    {

		// commands
		// +add, (kind of animal, Alias)
		// +feed (alias)
		// treat (alias)
		// remove (alias)
		// show (-all/alias)
		// help
        private readonly List<Animal> _aAnimals;
		private readonly List<CommandBase> _aCommands;
		private bool _bAllAnimalsDead;
        public Zoo()
        {

			_aAnimals = new List<Animal>();
			_aCommands = new List<CommandBase>();
			RegisterCommands();

			_bAllAnimalsDead = false;

			SetTimer(out Timer timer);
			Loop();
			Console.WriteLine("Closed");
            timer.Stop();
            timer.Dispose();
        }

        private void Loop()
        {
			while (true)
            {
				if(_bAllAnimalsDead)
				{
					Console.WriteLine("Zoo closed. All animals was dead(");
					break;
				}
				string str = Console.ReadLine();
				List<string> arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				bool bInvalidCommand = true;
				if (arr.Count == 0)
					continue;
				foreach (CommandBase cmd in _aCommands)
				{
					if (cmd.CommandStr == arr[0])
					{
						bInvalidCommand = false;
						arr.RemoveAt(0);
						Console.WriteLine(CommandBase.ReturnCodeToString(cmd.Execute(arr.ToArray())));
						break;
					}
				}
				if(bInvalidCommand)
					Console.WriteLine("Invalid command.You can write 'help' to get list of all commands.");
            }
        }
		private void RegisterCommands()
		{
			_aCommands.AddRange(
				new CommandBase[] 
				{
					new CommandAdd(_aAnimals),
					new CommandFeed(_aAnimals),
					new CommandsRemove(_aAnimals),
					new CommandShow(_aAnimals),
					new CommandTreat(_aAnimals),
					new CommandHelp(_aCommands)
				});
		}
        private void SetTimer(out Timer timer)
        {
            timer = new Timer(5000);
            timer.Elapsed += OnTimerTick;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimerTick(Object source, ElapsedEventArgs e)
        {
			Random rand = new Random((int)(DateTime.Now.Ticks & 0x0000FFFF));
			var arrOfLifeAnimals = _aAnimals.Select(an => an).Where(an=> an.StateOfAnimal != Animal.State.Dead);
			if (arrOfLifeAnimals.Count() == 0)
				return;
			int nIndex = rand.Next(arrOfLifeAnimals.Count());
			Animal animal = _aAnimals[nIndex];

			switch(animal.StateOfAnimal)
			{
				case Animal.State.Hungry:
					animal.StateOfAnimal = Animal.State.Sick;
					break;
				case Animal.State.Sick:
					animal.Health--;
					break;
				case Animal.State.Sated:
					animal.StateOfAnimal = Animal.State.Hungry;
					break;
				default:
					break;
			}

			if(animal.Health == 0)
			{
				animal.StateOfAnimal = Animal.State.Dead;
				bool bAllDead = true;
				foreach(Animal an in _aAnimals)
				{
					if (animal.StateOfAnimal != Animal.State.Dead)
					{
						bAllDead = false;
						break;
					}
				}
				_bAllAnimalsDead = bAllDead;
			}
        }

    }
}
