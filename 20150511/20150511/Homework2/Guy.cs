using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //加入這條使用MessageBox方法

namespace Homework2
{
	internal class Guy
	{
		public string _name;
		public int _cash;

		public int GiveCash(int amount)
		{
			if (amount <= _cash && amount > 0)
			{
				_cash -= amount;
				return amount;
			}
			else
			{
				MessageBox.Show("我沒有足夠的錢給你 " + amount, _name + " 說道...");
				return 0;
			}
		}

		public int RecieveCash(int amount)
		{
			if (amount > 0)
			{
				_cash += amount;
				return amount;
			}
			else
			{
				MessageBox.Show(amount + " 我沒有收到錢!", _name + "說道...");
				return 0;
			}
		}
	}
}