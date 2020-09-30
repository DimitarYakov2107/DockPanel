namespace MyDockPanel
{
	partial class MainForm
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
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.addFomrsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockPanel.Location = new System.Drawing.Point(0, 42);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1479, 1028);
            this.dockPanel.TabIndex = 0;
            // 
            // addFomrsButton
            // 
            this.addFomrsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addFomrsButton.Location = new System.Drawing.Point(0, 0);
            this.addFomrsButton.Name = "addFomrsButton";
            this.addFomrsButton.Size = new System.Drawing.Size(1479, 44);
            this.addFomrsButton.TabIndex = 3;
            this.addFomrsButton.Text = "Click to add new form";
            this.addFomrsButton.UseVisualStyleBackColor = true;
            this.addFomrsButton.Click += new System.EventHandler(this.AddFomrsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 1070);
            this.Controls.Add(this.addFomrsButton);
            this.Controls.Add(this.dockPanel);
            this.HideOnClose = true;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.ResumeLayout(false);

		}

		#endregion

		private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
		private System.Windows.Forms.Button addFomrsButton;
	}
}

