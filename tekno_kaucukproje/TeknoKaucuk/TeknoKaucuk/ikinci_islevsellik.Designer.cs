namespace TeknoKaucuk
{
	partial class ikinci_islevsellik
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
			this.sayi_list = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// sayi_list
			// 
			this.sayi_list.BackColor = System.Drawing.SystemColors.Info;
			this.sayi_list.FormattingEnabled = true;
			this.sayi_list.ItemHeight = 16;
			this.sayi_list.Location = new System.Drawing.Point(116, 73);
			this.sayi_list.Name = "sayi_list";
			this.sayi_list.Size = new System.Drawing.Size(571, 292);
			this.sayi_list.TabIndex = 0;
			// 
			// ikinci_islevsellik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.sayi_list);
			this.Name = "ikinci_islevsellik";
			this.Text = "ikinci_islevsellik";
			this.Load += new System.EventHandler(this.ikinci_islevsellik_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox sayi_list;
	}
}