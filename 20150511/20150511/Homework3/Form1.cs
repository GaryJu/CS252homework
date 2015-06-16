using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
	public partial class Form1 : Form
	{
		private Graph rectangle;

		public Form1()
		{
			InitializeComponent();
			rectangle = new Graph();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			rectangle._high = int.Parse(highTextBox.Text);
			rectangle._weight = int.Parse(weightTextBox.Text);

			rectangle.DrawRectangle();
		}
	}
}