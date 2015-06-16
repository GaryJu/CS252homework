using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
	public partial class Form1 : Form
	{
		private Car BMW;

		public Form1()
		{
			InitializeComponent();
			BMW = new Car();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int speed = int.Parse(speedTextBox.Text);
			BMW.speed = speed;
			MessageBox.Show("合理車速應該為: " + BMW.speed);
		}
	}
}