namespace InterfaceProgramming.Chapter8 {
    partial class DrawShapes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.drawPanel = new System.Windows.Forms.Panel();
			this.hoverPanel = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.drawPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(516, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.clearAllToolStripMenuItem.Text = "Clear All";
			this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolToolStripMenuItem
			// 
			this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
			this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
			this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.toolToolStripMenuItem.Text = "Tool";
			// 
			// optionToolStripMenuItem
			// 
			this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
			this.optionToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.optionToolStripMenuItem.Text = "Option...";
			this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
			// 
			// drawPanel
			// 
			this.drawPanel.Controls.Add(this.hoverPanel);
			this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.drawPanel.Location = new System.Drawing.Point(0, 24);
			this.drawPanel.Name = "drawPanel";
			this.drawPanel.Size = new System.Drawing.Size(516, 403);
			this.drawPanel.TabIndex = 1;
			// 
			// hoverPanel
			// 
			this.hoverPanel.BackColor = System.Drawing.Color.Transparent;
			this.hoverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hoverPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.hoverPanel.Location = new System.Drawing.Point(0, 0);
			this.hoverPanel.Name = "hoverPanel";
			this.hoverPanel.Size = new System.Drawing.Size(516, 403);
			this.hoverPanel.TabIndex = 2;
			this.hoverPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.hoverPanel_Paint);
			this.hoverPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hoverPanel_MouseClick);
			this.hoverPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hoverPanel_MouseMove);
			// 
			// DrawShapes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 427);
			this.Controls.Add(this.drawPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "DrawShapes";
			this.Text = "Draw shapes";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DrawShapes_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.drawPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Panel hoverPanel;
    }
}