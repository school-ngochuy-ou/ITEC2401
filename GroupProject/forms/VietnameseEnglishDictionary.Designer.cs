
namespace GroupProject.forms {
	partial class VietnameseEnglishDictionary {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
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
			this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.searchEnglishRdBtn = new System.Windows.Forms.RadioButton();
			this.searchVietnameseRdBtn = new System.Windows.Forms.RadioButton();
			this.listBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(718, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.fileToolStripMenuItem.Text = "Word";
			// 
			// collectionToolStripMenuItem
			// 
			this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
			this.collectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.collectionToolStripMenuItem.Text = "Collection";
			this.collectionToolStripMenuItem.Click += new System.EventHandler(this.collectionToolStripMenuItem_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(6, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(590, 30);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.SystemColors.Highlight;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(602, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.searchEnglishRdBtn);
			this.groupBox1.Controls.Add(this.searchVietnameseRdBtn);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(694, 79);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search";
			// 
			// searchEnglishRdBtn
			// 
			this.searchEnglishRdBtn.AutoSize = true;
			this.searchEnglishRdBtn.Location = new System.Drawing.Point(92, 56);
			this.searchEnglishRdBtn.Name = "searchEnglishRdBtn";
			this.searchEnglishRdBtn.Size = new System.Drawing.Size(59, 17);
			this.searchEnglishRdBtn.TabIndex = 4;
			this.searchEnglishRdBtn.Text = "English";
			this.searchEnglishRdBtn.UseVisualStyleBackColor = true;
			// 
			// searchVietnameseRdBtn
			// 
			this.searchVietnameseRdBtn.AutoSize = true;
			this.searchVietnameseRdBtn.Checked = true;
			this.searchVietnameseRdBtn.Location = new System.Drawing.Point(6, 55);
			this.searchVietnameseRdBtn.Name = "searchVietnameseRdBtn";
			this.searchVietnameseRdBtn.Size = new System.Drawing.Size(80, 17);
			this.searchVietnameseRdBtn.TabIndex = 3;
			this.searchVietnameseRdBtn.TabStop = true;
			this.searchVietnameseRdBtn.Text = "Vietnamese";
			this.searchVietnameseRdBtn.UseVisualStyleBackColor = true;
			// 
			// listBox
			// 
			this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(12, 112);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(236, 511);
			this.listBox.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(254, 112);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(446, 511);
			this.panel1.TabIndex = 5;
			// 
			// VietnameseEnglishDictionary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(718, 639);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "VietnameseEnglishDictionary";
			this.Text = "Vietnamese-English Dictionary";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton searchEnglishRdBtn;
		private System.Windows.Forms.RadioButton searchVietnameseRdBtn;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
	}
}