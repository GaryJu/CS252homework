namespace SalaryCount
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.title = new System.Windows.Forms.Label();
			this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
			this.benefitTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.title.Location = new System.Drawing.Point(133, 32);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(195, 35);
			this.title.TabIndex = 0;
			this.title.Text = "薪水試算表";
			// 
			// baseSalaryTextBox
			// 
			this.baseSalaryTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.baseSalaryTextBox.Location = new System.Drawing.Point(223, 108);
			this.baseSalaryTextBox.Name = "baseSalaryTextBox";
			this.baseSalaryTextBox.Size = new System.Drawing.Size(100, 33);
			this.baseSalaryTextBox.TabIndex = 1;
			// 
			// benefitTextBox
			// 
			this.benefitTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.benefitTextBox.Location = new System.Drawing.Point(223, 170);
			this.benefitTextBox.Name = "benefitTextBox";
			this.benefitTextBox.Size = new System.Drawing.Size(100, 33);
			this.benefitTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(135, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "底薪";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(135, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "獎金";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(223, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 41);
			this.button1.TabIndex = 5;
			this.button1.Text = "計算薪水";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 324);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.benefitTextBox);
			this.Controls.Add(this.baseSalaryTextBox);
			this.Controls.Add(this.title);
			this.Name = "Form1";
			this.Text = "薪水試算程式";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.TextBox baseSalaryTextBox;
		private System.Windows.Forms.TextBox benefitTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}

