using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honework6
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("請輸入1~10數字中，想消失的一個數: ");
			int x = int.Parse(Console.ReadLine());
			int i = 0;
			for (i = 1; i < 11; i++)
			{
				if (x == i)
					continue;
				Console.WriteLine(i);
			}
		}
	}
}