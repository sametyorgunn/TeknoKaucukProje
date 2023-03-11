using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucuk
{
	public partial class dorduncu_islevsellik : Form
	{
		public dorduncu_islevsellik()
		{
			InitializeComponent();
		}

		private void sirala_btn_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Text Files|*.txt";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string[] lines = File.ReadAllLines(openFileDialog1.FileName);

				List<double> numbers = new List<double>();
				foreach (string line in lines)
				{
					string[] lineNumbers = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (string lineNumber in lineNumbers)
					{
						double number;
						if (double.TryParse(lineNumber.Replace(",", "."), out number))
						{
							numbers.Add(number);
						}
					}
				}
				numbers.Sort();

				listBox1.Items.Clear();
				foreach (double number in numbers)
				{
					listBox1.Items.Add(number.ToString());
				}
			}
		}

		private void dorduncu_islevsellik_Load(object sender, EventArgs e)
		{

		}
	}
}
