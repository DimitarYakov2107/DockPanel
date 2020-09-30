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
	public partial class Form1 : DockContent
	{
		public Form1()
		{
			InitializeComponent();

			this.AutoScaleMode = AutoScaleMode.Font;
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			this.AutoScaleMode = AutoScaleMode.Font;
		}
	}
}
