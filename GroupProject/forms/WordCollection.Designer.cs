
namespace GroupProject.forms {
	partial class WordCollection {
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
			this.languageComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.messageLabel = new System.Windows.Forms.Label();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.newWordBtn = new System.Windows.Forms.Button();
			this.editWordBtn = new System.Windows.Forms.Button();
			this.deleteWordBtn = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(809, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// languageComboBox
			// 
			this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.languageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.languageComboBox.FormattingEnabled = true;
			this.languageComboBox.Location = new System.Drawing.Point(73, 27);
			this.languageComboBox.Name = "languageComboBox";
			this.languageComboBox.Size = new System.Drawing.Size(226, 24);
			this.languageComboBox.TabIndex = 1;
			this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Language";
			// 
			// listBox
			// 
			this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 18;
			this.listBox.Location = new System.Drawing.Point(12, 70);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(287, 400);
			this.listBox.TabIndex = 3;
			this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchTextBox.Location = new System.Drawing.Point(12, 485);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(191, 31);
			this.searchTextBox.TabIndex = 4;
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			// 
			// searchBtn
			// 
			this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.searchBtn.BackColor = System.Drawing.SystemColors.Highlight;
			this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.searchBtn.Location = new System.Drawing.Point(209, 485);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(90, 31);
			this.searchBtn.TabIndex = 5;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = false;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// messageLabel
			// 
			this.messageLabel.AutoSize = true;
			this.messageLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.messageLabel.Location = new System.Drawing.Point(12, 54);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.messageLabel.Size = new System.Drawing.Size(0, 13);
			this.messageLabel.TabIndex = 6;
			// 
			// richTextBox
			// 
			this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox.Enabled = false;
			this.richTextBox.Location = new System.Drawing.Point(305, 70);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.ReadOnly = true;
			this.richTextBox.Size = new System.Drawing.Size(492, 446);
			this.richTextBox.TabIndex = 7;
			this.richTextBox.Text = "";
			// 
			// newWordBtn
			// 
			this.newWordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.newWordBtn.BackColor = System.Drawing.SystemColors.Highlight;
			this.newWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newWordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newWordBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.newWordBtn.Location = new System.Drawing.Point(707, 31);
			this.newWordBtn.Name = "newWordBtn";
			this.newWordBtn.Size = new System.Drawing.Size(90, 33);
			this.newWordBtn.TabIndex = 8;
			this.newWordBtn.Text = "New word";
			this.newWordBtn.UseVisualStyleBackColor = false;
			this.newWordBtn.Click += new System.EventHandler(this.newWordBtn_Click);
			// 
			// editWordBtn
			// 
			this.editWordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.editWordBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.editWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editWordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editWordBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.editWordBtn.Location = new System.Drawing.Point(611, 31);
			this.editWordBtn.Name = "editWordBtn";
			this.editWordBtn.Size = new System.Drawing.Size(90, 33);
			this.editWordBtn.TabIndex = 9;
			this.editWordBtn.Text = "Edit word";
			this.editWordBtn.UseVisualStyleBackColor = false;
			this.editWordBtn.Click += new System.EventHandler(this.editWordBtn_Click);
			// 
			// deleteWordBtn
			// 
			this.deleteWordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteWordBtn.BackColor = System.Drawing.Color.OrangeRed;
			this.deleteWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteWordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteWordBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.deleteWordBtn.Location = new System.Drawing.Point(494, 31);
			this.deleteWordBtn.Name = "deleteWordBtn";
			this.deleteWordBtn.Size = new System.Drawing.Size(111, 33);
			this.deleteWordBtn.TabIndex = 10;
			this.deleteWordBtn.Text = "Delete word";
			this.deleteWordBtn.UseVisualStyleBackColor = false;
			this.deleteWordBtn.Click += new System.EventHandler(this.deleteWordBtn_Click);
			// 
			// WordCollection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 528);
			this.Controls.Add(this.deleteWordBtn);
			this.Controls.Add(this.editWordBtn);
			this.Controls.Add(this.newWordBtn);
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.languageComboBox);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "WordCollection";
			this.Text = "Word Collection";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ComboBox languageComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.Label messageLabel;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.Button newWordBtn;
		private System.Windows.Forms.Button editWordBtn;
		private System.Windows.Forms.Button deleteWordBtn;
	}
}