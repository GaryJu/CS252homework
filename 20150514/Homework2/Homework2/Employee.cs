using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
	internal class Employee
	{
		private int _baseSalary;

		public int BaseSalary
		{
			get { return _baseSalary; }

			set
			{
				if (value < 20000)
					this._baseSalary = 20000;
				else if (value > 40000)
					this._baseSalary = 40000;
				else
					this._baseSalary = value;
			}
		}
	}
}