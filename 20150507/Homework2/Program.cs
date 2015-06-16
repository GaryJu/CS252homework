using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("請輸入月份: ");
			int month = int.Parse(Console.ReadLine());

			switch (month)
			{
				case 12:
				case 1:
				case 2:
					Console.WriteLine("冬季");
					break;

				case 3:
				case 4:
				case 5:
					Console.WriteLine("春季");
					break;

				case 6:
				case 7:
				case 8:
					Console.WriteLine("夏季");
					break;

				case 9:
				case 10:
				case 11:
					Console.WriteLine("秋季");
					break;

				default:
					Console.WriteLine("請重新輸入月份...");
					break;
			}
		}
	}
}