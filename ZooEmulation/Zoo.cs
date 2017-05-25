﻿using System;
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
        public Zoo()
        {

			_aAnimals = new List<Animal>();
			_aCommands = new List<CommandBase>();

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
				string str = Console.ReadLine();
				
                ; // do nothing
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
					new CommandsShow(_aAnimals),
					new CommandsTreat(_aAnimals)
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

        }

    }
}
