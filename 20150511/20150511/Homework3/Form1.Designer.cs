namespace Homework3
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
			this.highTextBox = new System.Windows.Forms.TextBox();
			this.weightTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.highLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// highTextBox
			// 
			this.highTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.highTextBox.Location = new System.Drawing.Point(118, 54);
			this.highTextBox.Name = "highTextBox";
			this.highTextBox.Size = new System.Drawing.Size(100, 27);
			this.highTextBox.TabIndex = 0;
			// 
			// weightTextBox
			// 
			this.weightTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.weightTextBox.Location = new System.Drawing.Point(118, 104);
			this.weightTextBox.Name = "weightTextBox";
			this.weightTextBox.Size = new System.Drawing.Size(100, 27);
			this.weightTextBox.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(118, 171);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "Draw it!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// highLabel
			// 
			this.highLabel.AutoSize = true;
			this.highLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.highLabel.Location = new System.Drawing.Point(58, 57);
			this.highLabel.Name = "highLabel";
			this.highLabel.Size = new System.Drawing.Size(44, 16);
			this.highLabel.TabIndex = 3;
			this.highLabel.Text = "高度:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(58, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "寬度:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.highLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.weightTextBox);
			this.Controls.Add(this.highTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox highTextBox;
		private System.Windows.Forms.TextBox weightTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label highLabel;
		private System.Windows.Forms.Label label2;
	}
}

