using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooEmulation.Commands
{
	abstract class CommandCmd : CommandBase
	{
		protected readonly List<CommandBase> _aCommands;
		public CommandCmd(string sCommand, List<CommandBase> commands) : base(sCommand)
		{
			_aCommands = commands;
		}
	}
}
