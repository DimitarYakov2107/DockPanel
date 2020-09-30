using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MyDockPanel
{
	public partial class Form2 : DockContent
	{
		public Form2()
		{
			InitializeComponent();
			this.AutoScaleMode = AutoScaleMode.Font;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.AutoScaleMode = AutoScaleMode.Font;
			f4.Show();

		}

		private void Form2_DragDrop(object sender, DragEventArgs e)
		{
			this.AutoScaleMode = AutoScaleMode.Font;
		}

		private void Button2_Click(object sender, EventArgs e)
		{

		}
	}
}
