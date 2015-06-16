using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
	internal class Graph
	{
		public int _high;
		public int _weight;

		public void DrawRectangle()
		{
			string result = "";
			for (int i = 0; i < _high; i++)
			{
				for (int j = 0; j < _weight; j++)
				{
					result += "*";
				}
				result += "\r\n";
			}
			MessageBox.Show(result);
		}
	}
}