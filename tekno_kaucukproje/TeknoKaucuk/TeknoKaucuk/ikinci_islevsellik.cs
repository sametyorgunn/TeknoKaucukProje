using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoKaucuk
{
	public partial class ikinci_islevsellik : Form
	{
		public ikinci_islevsellik()
		{
			InitializeComponent();
		}

		private void ikinci_islevsellik_Load(object sender, EventArgs e)
		{
			for(int i = 1; i <= 200; i++)
			{
				if (i < 100)
				{
					if (i % 3 == 0)
					{
						if (i % 3 == 0 && i % 5 == 0)
						{
							sayi_list.Items.Add("zigzag");
						}
						else
						{
							sayi_list.Items.Add("zig");
						}
					}

					else if (i % 5 == 0)
					{
						if (i % 3 == 0 && i % 5 == 0)
						{
							sayi_list.Items.Add("zigzag");
						}
						else
						{
							sayi_list.Items.Add("zag");
						}
					}
					else
					{
						sayi_list.Items.Add(i);
					}
				}
				else
				{
					if (i % 3 == 0)
					{
						if (i % 3 == 0 && i % 5 == 0)
						{
							sayi_list.Items.Add("zagzig");
						}
						else
						{
							sayi_list.Items.Add("zig");
						}
					}

					else if (i % 5 == 0)
					{
						if (i % 3 == 0 && i % 5 == 0)
						{
							sayi_list.Items.Add("zagzig");
						}
						else
						{
							sayi_list.Items.Add("zag");
						}
					}
					else
					{
						sayi_list.Items.Add(i);
					}
				}
			}
		}
	}
}
