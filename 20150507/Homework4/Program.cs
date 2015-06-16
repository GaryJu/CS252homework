using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("請輸入一個整數值: ");
			int x = int.Parse(Console.ReadLine());
			int i = 0;
			Console.Write(x + "! = ");
			while (i < x - 1)
			{
				i++;
				Console.Write(i + " * ");
			}
			Console.Write(x);
		}
	}
}