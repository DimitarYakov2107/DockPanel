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
	public partial class MainForm : DockContent
	{
		public MainForm()
		{
			InitializeComponent();
			//Form2 f1 = new Form2();
			//f1.Show(dockPanel, DockState.DockLeft);
			//Form2 f2 = new Form2();
			//f2.Show(dockPanel, DockState.DockLeft);
			//Form3 f3 = new Form3();
			//f3.Show(dockPanel, DockState.DockRight);
			//Form4 f4 = new Form4();
			//f4.Show(dockPanel, DockState.Document);

			//this.AutoScaleMode = AutoScaleMode.Font;
		}

		private void AddFomrsButton_Click(object sender, EventArgs e)
		{
			Form1 newForm = new Form1();
			newForm.Show(dockPanel, DockState.Float);
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			//this.AutoScaleMode = AutoScaleMode.Font;
		}
	}
}
