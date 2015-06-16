using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Random random = new Random();
			int x = 0;
			int y = random.Next(1, 101);
			do
			{
				Console.WriteLine("請輸入一個 0 ~ 100 間的數字: ");
				x = int.Parse(Console.ReadLine());

				if (y == x)
					Console.WriteLine("靠! 你也太神了吧! 居然猜中了!");
				else
				{
					Console.WriteLine("再試一次吧!");
				}
			} while (x != y);
		}
	}
}