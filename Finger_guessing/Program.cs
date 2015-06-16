using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finger_guessing
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("請出拳: ");
			int 我出的拳 = int.Parse(Console.ReadLine());

			Random random = new Random();
			int 電腦出的拳 = random.Next(1, 4);

			if (我出的拳 == 電腦出的拳)
			{
				Console.WriteLine("平手!!");
			}
			else if (我出的拳 - 電腦出的拳 == 1 || 我出的拳 - 電腦出的拳 == -2)
			{
				Console.WriteLine("你贏了!!");
			}
			else
			{
				Console.WriteLine("你輸囉!!");
			}

			Console.WriteLine("其實電腦出的是: " + 電腦出的拳);
		}
	}
}