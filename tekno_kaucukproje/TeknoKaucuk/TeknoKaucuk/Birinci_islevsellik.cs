using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucuk
{
	public partial class Birinci_islevsellik : Form
	{
		public Birinci_islevsellik()
		{
			InitializeComponent();
		}

		private void sonuc_goster_btn_Click(object sender, EventArgs e)
		{
			var sayibir = Convert.ToInt32(sayi1_txt.Text);
			var sayiiki = Convert.ToInt32(sayi2_txt.Text);
			var sayiuc = Convert.ToInt32(sayi3_txt.Text);

			var toplam = sayibir + sayiiki;
			var carpim = toplam * sayiuc;
			var sonuc = carpim;

			sonuc_txt.Text = Convert.ToString(sonuc);
			


		}

		private void Birinci_islevsellik_Load(object sender, EventArgs e)
		{
			sonuc_txt.Enabled = false;
		}
	}
}
