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
	public partial class Anasayfa : Form
	{
		public Anasayfa()
		{
			InitializeComponent();
		}

		private void Birinci_islevsellik_Click(object sender, EventArgs e)
		{
			Anasayfa form = new Anasayfa();
			form.Close();
			Birinci_islevsellik birinci = new Birinci_islevsellik();
			birinci.Show();
		}

		private void ikinci_islevsellik_Click(object sender, EventArgs e)
		{
			Anasayfa form = new Anasayfa();
			form.Close();
			ikinci_islevsellik ikinci = new ikinci_islevsellik();
			ikinci.Show();
		}

		private void ucuncu_islevsellik_Click(object sender, EventArgs e)
		{
			Anasayfa form = new Anasayfa();
			form.Close();
			ucuncu_islevsellik ucuncu = new ucuncu_islevsellik();
			ucuncu.Show();
		}

		private void dorduncu_islevsellik_btn_Click(object sender, EventArgs e)
		{
			Anasayfa form = new Anasayfa();
			form.Close();
			dorduncu_islevsellik dort = new dorduncu_islevsellik();
			dort.Show();
		}

		private void besinci_islevsellik_Click(object sender, EventArgs e)
		{
			Anasayfa form = new Anasayfa();
			form.Close();
			besinci_islevsellik bes = new besinci_islevsellik();
			bes.Show();
		}
	}
}
