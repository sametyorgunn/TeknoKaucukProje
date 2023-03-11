using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknoKaucuk
{
	public partial class besinci_islevsellik : Form
	{
		public besinci_islevsellik()
		{
			InitializeComponent();
		}
		int seri;
		private void button1_Click(object sender, EventArgs e)
		{
			//	int islem1, islem2;
			//	islem1 = 0;
			//	islem2 = 1;
			//	if (float.Parse(fibonacci_txt.Text) == 0)
			//	{
			//		seri = 1;
			//	}
			//	else if (float.Parse(fibonacci_txt.Text) == 1)
			//	{
			//		seri = 1;
			//	} 
			//	else
			//	{
			//		for (int i = 0; i < float.Parse(fibonacci_txt.Text); i++) 
			//		{
			//			seri = islem1 + islem2;
			//			islem1 = islem2;
			//			islem2 = seri;
			//		}
			//	}
			//	label1.Text = seri.ToString();
			//	seri = 0;


			
			int sira = int.Parse(fibonacci_txt.Text);
			int fibonacci = 0, onceki = 0, sonraki = 1;
			sira--;

			if (sira == 1) fibonacci = 1;

			for (int sirasi = 2; sirasi <= sira; sirasi++)
			{
				fibonacci = onceki + sonraki;
				onceki = sonraki;
				sonraki = fibonacci;
			}
			label1.Text = fibonacci.ToString();
		}
	}
}
