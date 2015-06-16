using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
	public partial class Form1 : Form
	{
		private Guy joe;
		private Guy bob;
		private int bank = 100;

		public Form1()
		{
			InitializeComponent();
			joe = new Guy();
			joe._name = "Joe";
			joe._cash = 50;

			bob = new Guy();
			bob._name = "Bob";
			bob._cash = 100;
		}

		public void UpdateForm()
		{
			joesCashLabel.Text = joe._name + " has $" + joe._cash;
			bobsCashLabel.Text = bob._name + " has $" + bob._cash;
			bankCashLabel.Text = "The bank has $" + bank;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (bank >= 10)
			{
				bank -= joe.RecieveCash(10);
				UpdateForm();
			}
			else
			{
				MessageBox.Show("銀行破產!", "oh no~");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			bank += bob.GiveCash(5);
			UpdateForm();
		}
	}
}