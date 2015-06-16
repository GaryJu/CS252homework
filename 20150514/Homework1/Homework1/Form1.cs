using GuyLibrary;  //加入類別庫
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
		private Guy Joe;
		private Guy Bob;

		public Form1()
		{
			InitializeComponent();
			Joe = new Guy("Joe", 2000);
			Bob = new Guy("Bob", 5000);

			UpdateLabel();
		}

		public void UpdateLabel()
		{
			nameLabel1.Text = this.Joe.Name;
			nameLabel2.Text = this.Bob.Name;
			cashLabel1.Text = this.Joe.Cash.ToString();
			cashLabel2.Text = this.Bob.Cash.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Bob.RecieceCash(this.Joe.GiveCash(200));
			UpdateLabel();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Joe.RecieceCash(this.Bob.GiveCash(500));
			UpdateLabel();
		}
	}
}