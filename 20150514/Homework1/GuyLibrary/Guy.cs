using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuyLibrary
{
	public class Guy
	{
		private string _name;

		public string Name { get; set; }

		private int _cash;

		public int Cash
		{
			get { return _cash; }
			set
			{
				_cash = (value < 0) ? 0 : value;
			}
		}

		public string Message { get; set; }

		public Guy(string name, int cash)
		{
			this.Name = name;
			this.Cash = cash;
		}

		public int GiveCash(int amount)
		{
			if (this.Cash >= amount && amount > 0)
			{
				this.Cash -= amount;
				return amount;
			}
			else
			{
				this.Message = string.Format("我身上不夠 {0} 元", amount);
				MessageBox.Show(this.Message);
				return 0;
			}
		}

		public int RecieceCash(int amount)
		{
			if (amount > 0)
			{
				this.Cash += amount;
				return amount;
			}
			else
				return 0;
		}
	}
}