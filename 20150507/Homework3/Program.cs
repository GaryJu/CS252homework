using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("請輸入一個整數值: ");
			int x = int.Parse(Console.ReadLine());

			int sum = 0;
			if (x % 2 == 1)
			{
				for (int i = 1; i <= x; i += 2)
				{
					sum += i;
					Console.WriteLine("x的奇數有: " + i + " ");
				}
				Console.WriteLine("x的值為奇數!! \n1 ~ " + x + " 間的奇數和為: " + sum);
			}
			else if (x % 2 == 0)
			{
				for (int i = 1; i <= x; i += 2)
				{
					sum += i;
					Console.WriteLine("x的偶數有: " + i + " ");
				}
				Console.WriteLine("x的值為偶數!! \n1 ~" + x + " 間的奇數和為: " + sum);
			}
			Console.ReadLine();
		}
	}
}