namespace Homework2
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
			this.joesCashLabel = new System.Windows.Forms.Label();
			this.bobsCashLabel = new System.Windows.Forms.Label();
			this.bankCashLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// joesCashLabel
			// 
			this.joesCashLabel.AutoSize = true;
			this.joesCashLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.joesCashLabel.Location = new System.Drawing.Point(118, 78);
			this.joesCashLabel.Name = "joesCashLabel";
			this.joesCashLabel.Size = new System.Drawing.Size(104, 21);
			this.joesCashLabel.TabIndex = 0;
			this.joesCashLabel.Text = "Joe has $50";
			// 
			// bobsCashLabel
			// 
			this.bobsCashLabel.AutoSize = true;
			this.bobsCashLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.bobsCashLabel.Location = new System.Drawing.Point(118, 119);
			this.bobsCashLabel.Name = "bobsCashLabel";
			this.bobsCashLabel.Size = new System.Drawing.Size(120, 21);
			this.bobsCashLabel.TabIndex = 1;
			this.bobsCashLabel.Text = "Bob has $100";
			// 
			// bankCashLabel
			// 
			this.bankCashLabel.AutoSize = true;
			this.bankCashLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.bankCashLabel.Location = new System.Drawing.Point(118, 161);
			this.bankCashLabel.Name = "bankCashLabel";
			this.bankCashLabel.Size = new System.Drawing.Size(162, 21);
			this.bankCashLabel.TabIndex = 2;
			this.bankCashLabel.Text = "The bank has $100";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(122, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 88);
			this.button1.TabIndex = 3;
			this.button1.Text = "給 Joe $10元";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(268, 231);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 88);
			this.button2.TabIndex = 4;
			this.button2.Text = "向 Bob 收 $5元";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 403);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bankCashLabel);
			this.Controls.Add(this.bobsCashLabel);
			this.Controls.Add(this.joesCashLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label joesCashLabel;
		private System.Windows.Forms.Label bobsCashLabel;
		private System.Windows.Forms.Label bankCashLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

