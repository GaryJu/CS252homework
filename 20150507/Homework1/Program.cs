using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("請輸入正方形的邊長: ");
			int x = int.Parse(Console.ReadLine());

			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < x; j++)
				{
					if (j == 0 || i == 0 || i == x - 1 || j == x - 1)
						Console.Write("*");
					else
						Console.Write(" ");
				}
				Console.WriteLine(); //換行動作
			}
		}
	}
}