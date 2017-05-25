using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooEmulation.Commands
{
	enum CommandsReturn
	{
		CR_INVALID_ARGS = 0,
		CR_ALL_RIGHT,
		CR_UNKNOWN_ANIMAL_TYPE,
		CR_ANIMAL_NOT_FOUND,
		CR_ANIMAL_WAS_DEAD,
		CR_ANIMAL_STILL_ALIVE,
		CR_OlREADY_EXIST,
	}
	abstract class CommandBase
	{
		protected readonly string _sCommandStr;

		public string CommandStr
		{
			get { return _sCommandStr; }
		}
		public abstract CommandsReturn Execute(string[] parameters);

		public CommandBase(string sCommand)
		{
			_sCommandStr = sCommand;
		}

		public new virtual string ToString()
		{
			return _sCommandStr;
		}

	}
}
