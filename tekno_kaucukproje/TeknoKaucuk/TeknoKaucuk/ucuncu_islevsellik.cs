using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknoKaucuk
{
	public partial class ucuncu_islevsellik : Form
	{
		public ucuncu_islevsellik()
		{
			InitializeComponent();
		}

		private void hesapla_Click(object sender, EventArgs e)
		{
			label1.Text = string.Empty;
			int sayi = int.Parse(carpim_tablo_txt.Text);
			for (int i = 0; i <= sayi; i++)
			{
				for (int j = 0; j <= sayi; j++)
				{
					int Sayi2 = 0;
					if (i == 0 && j == 0)
					{
						Sayi2 = 0;
					}
					else if (i == 0 && j != 0)
					{
						Sayi2 = j;

					}
					else if (i != 0 && j == 0)
					{
						Sayi2 = i;
					}
					else
					{
						Sayi2 = i * j;
					}
					string format = "{0," + (10 - Sayi2.ToString().Length) + "}";
					label1.Text += string.Format(format, Sayi2);
				}
				label1.Text += "\r\n";
			}

			int n = 0;
			if (int.TryParse(carpim_tablo_txt.Text, out n) && n >= 1 && n <= 15)
			{
				DataTable dt = new DataTable();
				for (int i = 1; i <= n; i++)
				{
					dt.Columns.Add(i.ToString(), typeof(int));
				}
				for (int i = 1; i <= n; i++)
				{
					DataRow dr = dt.NewRow();
					for (int j = 1; j <= n; j++)
					{
						dr[j - 1] = i * j;
					}
					dt.Rows.Add(dr);
				}
				dataGridView1.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Lütfen 1-15 arasında bir tam sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ucuncu_islevsellik_Load(object sender, EventArgs e)
		{

		}
	}
}
