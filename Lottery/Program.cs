﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
	internal class Program
	{
		private static Random yandom = new Random();
		private static int 我簽的號碼 = 0;

		private static void Main(string[] args)
		{
			人生模擬器();
		}

		public static void 人生模擬器()
		{
			買樂透();
			while (!中獎了())
			{
				買樂透();
				if (中獎了())
				{
					Console.WriteLine("爽，下課");
					break;
				}
				Console.WriteLine("繼續買，繼續上課");
			}
			Console.ReadLine();
		}

		public static void 買樂透()
		{
			//亂數產生器
			//Random random = new Random();
			我簽的號碼 = yandom.Next(1, 1001);
		}

		public static bool 中獎了()
		{
			//亂數產生器
			Random random = new Random();
			int 中獎號碼 = random.Next(1, 1001);
			return 我簽的號碼 == 中獎號碼;
		}
	}
}