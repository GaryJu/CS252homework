using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCount
{
	internal class Employee
	{
		private int _salary;

		public int salary
		{
			set
			{
				if (value <= 22000)
					this._salary = 22000;
				else if (value >= 60000)
					this._salary = 60000;
				else
					this._salary = value;
			}

			get
			{
				return this._salary;
			}
		}
	}
}