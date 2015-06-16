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
		public string Message { get; set; }

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Employee Tom = new Employee();
			Tom.BaseSalary = 45000;
			Message = string.Format("員工Tom的薪水為: {0}", Tom.BaseSalary);
			MessageBox.Show(this.Message);

			Manager Peter = new Manager();
			Peter.BaseSalary = 55000;
			Message = string.Format("經理Peter的底薪為: {0}", Peter.BaseSalary);
			MessageBox.Show(this.Message);
			Peter.Bonus = 15000;
			Message = string.Format("經理Peter的獎金為: {0}", Peter.Bonus);
			MessageBox.Show(this.Message);
			Peter.ShowTotal();

			Salesman Denny = new Salesman();
			Denny.BaseSalary = 50000;
			Message = string.Format("業務Denny的底薪為: {0}", Denny.BaseSalary);
			MessageBox.Show(this.Message);
			Denny.Bonus = 120;  //此值只是用來作條件比較，無意義
			Message = string.Format("業務Denny的獎金為: {0}", Denny.Bonus);
			MessageBox.Show(this.Message);
			Denny.ShowTotal();
		}
	}
}