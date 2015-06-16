using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCount
{
	public partial class Form1 : Form
	{
		private Employee Gary;

		public Form1()
		{
			InitializeComponent();
			Gary = new Employee();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//檢查輸入資料完整性
			if (baseSalaryTextBox.Text == "" || benefitTextBox.Text == "")
				MessageBox.Show("輸入不完全，請重新輸入!", "錯誤訊息");
			else
			{
				int salary = int.Parse(baseSalaryTextBox.Text) + int.Parse(benefitTextBox.Text);

				Gary.salary = salary;

				MessageBox.Show("您的底薪為: " + baseSalaryTextBox.Text + "\n 您的獎金為: " + benefitTextBox.Text + "\n 您的薪水是: " + Gary.salary.ToString(), "計算結果");
			}
		}
	}
}