
namespace GroupProject.forms {
	partial class WordView {
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
			this.label1 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.definitionTextBox = new System.Windows.Forms.TextBox();
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.languageComboBox = new System.Windows.Forms.ComboBox();
			this.sourceListBox = new System.Windows.Forms.ListBox();
			this.translationListBox = new System.Windows.Forms.ListBox();
			this.addTranslationBtn = new System.Windows.Forms.Button();
			this.removeTranslationBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.sourceSearchTextBox = new System.Windows.Forms.TextBox();
			this.translationSearchTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Word";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameTextBox.Location = new System.Drawing.Point(108, 6);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(483, 24);
			this.nameTextBox.TabIndex = 1;
			this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Type";
			// 
			// typeComboBox
			// 
			this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.typeComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(108, 43);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(483, 26);
			this.typeComboBox.TabIndex = 3;
			this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Definition";
			// 
			// definitionTextBox
			// 
			this.definitionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.definitionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.definitionTextBox.Location = new System.Drawing.Point(108, 83);
			this.definitionTextBox.Multiline = true;
			this.definitionTextBox.Name = "definitionTextBox";
			this.definitionTextBox.Size = new System.Drawing.Size(483, 54);
			this.definitionTextBox.TabIndex = 5;
			this.definitionTextBox.TextChanged += new System.EventHandler(this.definitionTextBox_TextChanged);
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.BackColor = System.Drawing.SystemColors.Highlight;
			this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.okBtn.Location = new System.Drawing.Point(501, 504);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(90, 33);
			this.okBtn.TabIndex = 9;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = false;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.cancelBtn.Location = new System.Drawing.Point(405, 504);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(90, 33);
			this.cancelBtn.TabIndex = 10;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = false;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 18);
			this.label5.TabIndex = 11;
			this.label5.Text = "Translate in";
			// 
			// languageComboBox
			// 
			this.languageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.languageComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.languageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.languageComboBox.FormattingEnabled = true;
			this.languageComboBox.Location = new System.Drawing.Point(108, 143);
			this.languageComboBox.Name = "languageComboBox";
			this.languageComboBox.Size = new System.Drawing.Size(483, 26);
			this.languageComboBox.TabIndex = 12;
			this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
			// 
			// sourceListBox
			// 
			this.sourceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sourceListBox.FormattingEnabled = true;
			this.sourceListBox.ItemHeight = 18;
			this.sourceListBox.Location = new System.Drawing.Point(108, 193);
			this.sourceListBox.Name = "sourceListBox";
			this.sourceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.sourceListBox.Size = new System.Drawing.Size(219, 274);
			this.sourceListBox.TabIndex = 13;
			// 
			// translationListBox
			// 
			this.translationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.translationListBox.FormattingEnabled = true;
			this.translationListBox.ItemHeight = 18;
			this.translationListBox.Location = new System.Drawing.Point(372, 193);
			this.translationListBox.Name = "translationListBox";
			this.translationListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.translationListBox.Size = new System.Drawing.Size(219, 274);
			this.translationListBox.TabIndex = 14;
			// 
			// addTranslationBtn
			// 
			this.addTranslationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addTranslationBtn.Location = new System.Drawing.Point(333, 288);
			this.addTranslationBtn.Name = "addTranslationBtn";
			this.addTranslationBtn.Size = new System.Drawing.Size(33, 36);
			this.addTranslationBtn.TabIndex = 15;
			this.addTranslationBtn.Text = ">>";
			this.addTranslationBtn.UseVisualStyleBackColor = true;
			this.addTranslationBtn.Click += new System.EventHandler(this.addTranslationBtn_Click);
			// 
			// removeTranslationBtn
			// 
			this.removeTranslationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeTranslationBtn.Location = new System.Drawing.Point(333, 338);
			this.removeTranslationBtn.Name = "removeTranslationBtn";
			this.removeTranslationBtn.Size = new System.Drawing.Size(33, 36);
			this.removeTranslationBtn.TabIndex = 16;
			this.removeTranslationBtn.Text = "<<";
			this.removeTranslationBtn.UseVisualStyleBackColor = true;
			this.removeTranslationBtn.Click += new System.EventHandler(this.removeTranslationBtn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label4.Location = new System.Drawing.Point(105, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 18);
			this.label4.TabIndex = 17;
			this.label4.Text = "Select";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label6.Location = new System.Drawing.Point(369, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 18);
			this.label6.TabIndex = 18;
			this.label6.Text = "Translation";
			// 
			// sourceSearchTextBox
			// 
			this.sourceSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sourceSearchTextBox.Location = new System.Drawing.Point(108, 474);
			this.sourceSearchTextBox.Name = "sourceSearchTextBox";
			this.sourceSearchTextBox.Size = new System.Drawing.Size(219, 24);
			this.sourceSearchTextBox.TabIndex = 19;
			this.sourceSearchTextBox.TextChanged += new System.EventHandler(this.sourceSearchTextBox_TextChanged);
			// 
			// translationSearchTextBox
			// 
			this.translationSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.translationSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.translationSearchTextBox.Location = new System.Drawing.Point(372, 474);
			this.translationSearchTextBox.Name = "translationSearchTextBox";
			this.translationSearchTextBox.Size = new System.Drawing.Size(219, 24);
			this.translationSearchTextBox.TabIndex = 20;
			this.translationSearchTextBox.TextChanged += new System.EventHandler(this.translationSearchTextBox_TextChanged);
			// 
			// WordView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 549);
			this.Controls.Add(this.translationSearchTextBox);
			this.Controls.Add(this.sourceSearchTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.removeTranslationBtn);
			this.Controls.Add(this.addTranslationBtn);
			this.Controls.Add(this.translationListBox);
			this.Controls.Add(this.sourceListBox);
			this.Controls.Add(this.languageComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.definitionTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label1);
			this.Name = "WordView";
			this.Text = "New Word";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox definitionTextBox;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox languageComboBox;
		private System.Windows.Forms.ListBox sourceListBox;
		private System.Windows.Forms.ListBox translationListBox;
		private System.Windows.Forms.Button addTranslationBtn;
		private System.Windows.Forms.Button removeTranslationBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox sourceSearchTextBox;
		private System.Windows.Forms.TextBox translationSearchTextBox;
	}
}