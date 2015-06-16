using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
	internal class Manager : Employee
	{
		public int Bonus { get; set; }

		public string Message { get; set; }

		public void ShowTotal()
		{
			Message = string.Format("經理Peter的實領薪水為: {0}", Bonus + BaseSalary);
			MessageBox.Show(this.Message);
		}
	}
}