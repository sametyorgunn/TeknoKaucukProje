namespace TeknoKaucuk
{
	partial class ucuncu_islevsellik
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
			this.carpim_tablo_txt = new System.Windows.Forms.TextBox();
			this.hesapla = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// carpim_tablo_txt
			// 
			this.carpim_tablo_txt.Location = new System.Drawing.Point(61, 41);
			this.carpim_tablo_txt.Name = "carpim_tablo_txt";
			this.carpim_tablo_txt.Size = new System.Drawing.Size(108, 22);
			this.carpim_tablo_txt.TabIndex = 0;
			// 
			// hesapla
			// 
			this.hesapla.Location = new System.Drawing.Point(61, 114);
			this.hesapla.Name = "hesapla";
			this.hesapla.Size = new System.Drawing.Size(100, 30);
			this.hesapla.TabIndex = 1;
			this.hesapla.Text = "hesapla";
			this.hesapla.UseVisualStyleBackColor = true;
			this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(252, 41);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(809, 354);
			this.dataGridView1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// ucuncu_islevsellik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1073, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.hesapla);
			this.Controls.Add(this.carpim_tablo_txt);
			this.Name = "ucuncu_islevsellik";
			this.Text = "ucuncu_islevsellik";
			this.Load += new System.EventHandler(this.ucuncu_islevsellik_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox carpim_tablo_txt;
		private System.Windows.Forms.Button hesapla;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
	}
}