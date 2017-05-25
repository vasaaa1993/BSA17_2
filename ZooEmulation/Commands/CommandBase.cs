using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooEmulation.Commands
{

	abstract class CommandBase
	{
		public enum CommandsReturn
		{
			CR_INVALID_ARGS = 0,
			CR_ALL_RIGHT,
			CR_UNKNOWN_ANIMAL_TYPE,
			CR_ANIMAL_NOT_FOUND,
			CR_ANIMAL_WAS_DEAD,
			CR_ANIMAL_STILL_ALIVE,
			CR_OlREADY_EXIST,
			CR_COUNT
		}

		static string[] _Descriptions = new string[(int)(CommandsReturn.CR_COUNT)]
		{
			"invalid input args",
			"ok",
			"unknown animal type",
			"animal not found",
			"Animal was dead. You can only remove this animal",
			"Animal still alive. You can remove only dead animals",
			"Animals with this alias already exist"
		};

		public static string ReturnCodeToString(CommandsReturn val)
		{
			return _Descriptions[(int)val];
		}
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
