using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
	internal class Salesman : Employee
	{
		private double _bonus;

		public double Bonus
		{
			get { return _bonus; }

			set
			{
				if (BaseSalary >= value)
					this._bonus = BaseSalary * 0.05;
			}
		}

		public string Message { get; set; }

		public void ShowTotal()
		{
			Message = string.Format("業務Denny的實領薪水為: {0}", Bonus + BaseSalary);
			MessageBox.Show(this.Message);
		}
	}
}