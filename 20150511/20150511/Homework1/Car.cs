using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
	internal class Car
	{
		private int _speedField;

		public int speed
		{
			set
			{
				if (value < 0)
					this._speedField = 0;
				else if (value > 100)
					this._speedField = 100;
				else
					this._speedField = value;
			}

			get
			{
				return this._speedField;
			}
		}
	}
}