using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooEmulation.Commands
{
	class CommandHelp : CommandCmd
	{
		public CommandHelp(List<CommandBase> commands) : base("help", commands)
		{
		}

		public override CommandsReturn Execute(string[] parameters)
		{
			Console.WriteLine("-----");
			if (_aCommands.Count == 0)
			{
				Console.WriteLine("No animals in the zoo(");
			}
			else
			{
				foreach(CommandBase cmd in _aCommands)
				{
					Console.WriteLine(cmd.ToString());
				}
			}
			Console.WriteLine("-----");
			return CommandsReturn.CR_ALL_RIGHT;
		}
	}
}
