﻿namespace TeknoKaucuk
{
	partial class besinci_islevsellik
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
			this.fibonacci_txt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// fibonacci_txt
			// 
			this.fibonacci_txt.Location = new System.Drawing.Point(316, 69);
			this.fibonacci_txt.Name = "fibonacci_txt";
			this.fibonacci_txt.Size = new System.Drawing.Size(110, 22);
			this.fibonacci_txt.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(316, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 31);
			this.button1.TabIndex = 1;
			this.button1.Text = "fibonacci bul";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(313, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 2;
			// 
			// besinci_islevsellik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.fibonacci_txt);
			this.Name = "besinci_islevsellik";
			this.Text = "besinci_islevsellik";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox fibonacci_txt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}