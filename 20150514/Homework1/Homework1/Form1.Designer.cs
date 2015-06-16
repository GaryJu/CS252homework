namespace Homework1
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.nameLabel1 = new System.Windows.Forms.Label();
			this.nameLabel2 = new System.Windows.Forms.Label();
			this.cashLabel1 = new System.Windows.Forms.Label();
			this.cashLabel2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(41, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(186, 94);
			this.button1.TabIndex = 0;
			this.button1.Text = "Joe拿$200給Bob";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(258, 213);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(186, 94);
			this.button2.TabIndex = 1;
			this.button2.Text = "Bob拿$500給Joe";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// nameLabel1
			// 
			this.nameLabel1.AutoSize = true;
			this.nameLabel1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nameLabel1.Location = new System.Drawing.Point(51, 61);
			this.nameLabel1.Name = "nameLabel1";
			this.nameLabel1.Size = new System.Drawing.Size(137, 27);
			this.nameLabel1.TabIndex = 2;
			this.nameLabel1.Text = "NameLabel1";
			// 
			// nameLabel2
			// 
			this.nameLabel2.AutoSize = true;
			this.nameLabel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nameLabel2.Location = new System.Drawing.Point(268, 61);
			this.nameLabel2.Name = "nameLabel2";
			this.nameLabel2.Size = new System.Drawing.Size(137, 27);
			this.nameLabel2.TabIndex = 3;
			this.nameLabel2.Text = "NameLabel2";
			// 
			// cashLabel1
			// 
			this.cashLabel1.AutoSize = true;
			this.cashLabel1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.cashLabel1.Location = new System.Drawing.Point(53, 129);
			this.cashLabel1.Name = "cashLabel1";
			this.cashLabel1.Size = new System.Drawing.Size(126, 27);
			this.cashLabel1.TabIndex = 4;
			this.cashLabel1.Text = "CashLabel1";
			// 
			// cashLabel2
			// 
			this.cashLabel2.AutoSize = true;
			this.cashLabel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.cashLabel2.Location = new System.Drawing.Point(270, 129);
			this.cashLabel2.Name = "cashLabel2";
			this.cashLabel2.Size = new System.Drawing.Size(126, 27);
			this.cashLabel2.TabIndex = 5;
			this.cashLabel2.Text = "CashLabel2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 369);
			this.Controls.Add(this.cashLabel2);
			this.Controls.Add(this.cashLabel1);
			this.Controls.Add(this.nameLabel2);
			this.Controls.Add(this.nameLabel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = " 你給我，我給你";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label nameLabel1;
		private System.Windows.Forms.Label nameLabel2;
		private System.Windows.Forms.Label cashLabel1;
		private System.Windows.Forms.Label cashLabel2;
	}
}

