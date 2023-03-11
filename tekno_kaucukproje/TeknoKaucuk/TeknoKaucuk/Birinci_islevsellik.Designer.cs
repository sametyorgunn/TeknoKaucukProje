namespace TeknoKaucuk
{
	partial class Birinci_islevsellik
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
			this.sayi1_txt = new System.Windows.Forms.TextBox();
			this.sayi2_txt = new System.Windows.Forms.TextBox();
			this.sayi3_txt = new System.Windows.Forms.TextBox();
			this.sonuc_txt = new System.Windows.Forms.TextBox();
			this.sonuc_goster_btn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// sayi1_txt
			// 
			this.sayi1_txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.sayi1_txt.Location = new System.Drawing.Point(163, 83);
			this.sayi1_txt.Name = "sayi1_txt";
			this.sayi1_txt.Size = new System.Drawing.Size(162, 22);
			this.sayi1_txt.TabIndex = 0;
			// 
			// sayi2_txt
			// 
			this.sayi2_txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.sayi2_txt.Location = new System.Drawing.Point(163, 138);
			this.sayi2_txt.Name = "sayi2_txt";
			this.sayi2_txt.Size = new System.Drawing.Size(162, 22);
			this.sayi2_txt.TabIndex = 1;
			// 
			// sayi3_txt
			// 
			this.sayi3_txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.sayi3_txt.Location = new System.Drawing.Point(163, 185);
			this.sayi3_txt.Name = "sayi3_txt";
			this.sayi3_txt.Size = new System.Drawing.Size(162, 22);
			this.sayi3_txt.TabIndex = 2;
			// 
			// sonuc_txt
			// 
			this.sonuc_txt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.sonuc_txt.Location = new System.Drawing.Point(163, 228);
			this.sonuc_txt.Name = "sonuc_txt";
			this.sonuc_txt.Size = new System.Drawing.Size(162, 22);
			this.sonuc_txt.TabIndex = 3;
			// 
			// sonuc_goster_btn
			// 
			this.sonuc_goster_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.sonuc_goster_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.sonuc_goster_btn.Location = new System.Drawing.Point(175, 291);
			this.sonuc_goster_btn.Name = "sonuc_goster_btn";
			this.sonuc_goster_btn.Size = new System.Drawing.Size(135, 53);
			this.sonuc_goster_btn.TabIndex = 4;
			this.sonuc_goster_btn.Text = "sonucu göster";
			this.sonuc_goster_btn.UseVisualStyleBackColor = false;
			this.sonuc_goster_btn.Click += new System.EventHandler(this.sonuc_goster_btn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "sayi 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "sayi 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "sayi 3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 228);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "sonuç";
			// 
			// Birinci_islevsellik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sonuc_goster_btn);
			this.Controls.Add(this.sonuc_txt);
			this.Controls.Add(this.sayi3_txt);
			this.Controls.Add(this.sayi2_txt);
			this.Controls.Add(this.sayi1_txt);
			this.Name = "Birinci_islevsellik";
			this.Text = "Birinci_islevsellik";
			this.Load += new System.EventHandler(this.Birinci_islevsellik_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox sayi1_txt;
		private System.Windows.Forms.TextBox sayi2_txt;
		private System.Windows.Forms.TextBox sayi3_txt;
		private System.Windows.Forms.TextBox sonuc_txt;
		private System.Windows.Forms.Button sonuc_goster_btn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}