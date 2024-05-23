using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_Simulator
{
	static class SimulationConsole
	{
		private static List<string> messages = new List<string>();

		public static string WriteLine(string message)
		{
			//messages.Add(message);

			//string labelMessage = "";
			//for (int i = messages.Count - 1; (i >= messages.Count - 50 && i >= 0); i--)
			//{
			//	labelMessage += "> " + messages[i] + "\n";
			//}

			//return labelMessage;

			messages.Insert(0, message);

			string labelMessage = "";
			for (int i = 0; (i < 50 && i < messages.Count); i++)
			{
				labelMessage += "> " + messages[i] + "\n";
			}

			return labelMessage;
		}
	}
}
