﻿namespace TeknoKaucuk
{
	partial class dorduncu_islevsellik
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.sirala_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.Info;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(382, 37);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(393, 388);
			this.listBox1.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// sirala_btn
			// 
			this.sirala_btn.BackColor = System.Drawing.SystemColors.Info;
			this.sirala_btn.Location = new System.Drawing.Point(28, 65);
			this.sirala_btn.Name = "sirala_btn";
			this.sirala_btn.Size = new System.Drawing.Size(146, 45);
			this.sirala_btn.TabIndex = 1;
			this.sirala_btn.Text = "sırala";
			this.sirala_btn.UseVisualStyleBackColor = false;
			this.sirala_btn.Click += new System.EventHandler(this.sirala_btn_Click);
			// 
			// dorduncu_islevsellik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.sirala_btn);
			this.Controls.Add(this.listBox1);
			this.Name = "dorduncu_islevsellik";
			this.Text = "dorduncu_islevsellik";
			this.Load += new System.EventHandler(this.dorduncu_islevsellik_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button sirala_btn;
	}
}