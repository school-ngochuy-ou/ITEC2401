namespace InterfaceProgramming.Chapter4 {
    partial class SimpleEditor {
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
			this.label1 = new System.Windows.Forms.Label();
			this.fontFamilyBox = new System.Windows.Forms.ListBox();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.sizeDropDown = new System.Windows.Forms.ComboBox();
			this.bBtn = new System.Windows.Forms.Button();
			this.iBtn = new System.Windows.Forms.Button();
			this.uBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.redBar = new System.Windows.Forms.HScrollBar();
			this.greenBar = new System.Windows.Forms.HScrollBar();
			this.blueBar = new System.Windows.Forms.HScrollBar();
			this.colorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Font size";
			// 
			// fontFamilyBox
			// 
			this.fontFamilyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fontFamilyBox.FormattingEnabled = true;
			this.fontFamilyBox.ItemHeight = 16;
			this.fontFamilyBox.Location = new System.Drawing.Point(12, 29);
			this.fontFamilyBox.Name = "fontFamilyBox";
			this.fontFamilyBox.Size = new System.Drawing.Size(237, 372);
			this.fontFamilyBox.TabIndex = 1;
			this.fontFamilyBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyBox_SelectedIndexChanged);
			// 
			// richTextBox
			// 
			this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox.HideSelection = false;
			this.richTextBox.Location = new System.Drawing.Point(258, 29);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(370, 381);
			this.richTextBox.TabIndex = 2;
			this.richTextBox.Text = "";
			this.richTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(255, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Content";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 438);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Size";
			// 
			// sizeDropDown
			// 
			this.sizeDropDown.FormattingEnabled = true;
			this.sizeDropDown.Location = new System.Drawing.Point(53, 437);
			this.sizeDropDown.Name = "sizeDropDown";
			this.sizeDropDown.Size = new System.Drawing.Size(76, 21);
			this.sizeDropDown.TabIndex = 5;
			this.sizeDropDown.Text = "11";
			this.sizeDropDown.TextChanged += new System.EventHandler(this.sizeDropDown_TextChanged);
			// 
			// bBtn
			// 
			this.bBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bBtn.Location = new System.Drawing.Point(135, 430);
			this.bBtn.Name = "bBtn";
			this.bBtn.Size = new System.Drawing.Size(34, 32);
			this.bBtn.TabIndex = 6;
			this.bBtn.Text = "B";
			this.bBtn.UseVisualStyleBackColor = true;
			this.bBtn.Click += new System.EventHandler(this.bBtn_Click);
			// 
			// iBtn
			// 
			this.iBtn.Font = new System.Drawing.Font("VNI-Bodon", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iBtn.Location = new System.Drawing.Point(175, 430);
			this.iBtn.Name = "iBtn";
			this.iBtn.Size = new System.Drawing.Size(34, 32);
			this.iBtn.TabIndex = 7;
			this.iBtn.Text = "I";
			this.iBtn.UseVisualStyleBackColor = true;
			this.iBtn.Click += new System.EventHandler(this.iBtn_Click);
			// 
			// uBtn
			// 
			this.uBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uBtn.Location = new System.Drawing.Point(215, 430);
			this.uBtn.Name = "uBtn";
			this.uBtn.Size = new System.Drawing.Size(34, 32);
			this.uBtn.TabIndex = 8;
			this.uBtn.Text = "U";
			this.uBtn.UseVisualStyleBackColor = true;
			this.uBtn.Click += new System.EventHandler(this.uBtn_Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Red;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(264, 413);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 17);
			this.label4.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Green;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(264, 438);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 17);
			this.label5.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Blue;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(264, 463);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 17);
			this.label6.TabIndex = 11;
			// 
			// redBar
			// 
			this.redBar.Location = new System.Drawing.Point(287, 413);
			this.redBar.Maximum = 255;
			this.redBar.Name = "redBar";
			this.redBar.Size = new System.Drawing.Size(286, 17);
			this.redBar.TabIndex = 12;
			this.redBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redBar_Scroll);
			// 
			// greenBar
			// 
			this.greenBar.Location = new System.Drawing.Point(287, 437);
			this.greenBar.Maximum = 255;
			this.greenBar.Name = "greenBar";
			this.greenBar.Size = new System.Drawing.Size(286, 17);
			this.greenBar.TabIndex = 13;
			this.greenBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenBar_Scroll);
			// 
			// blueBar
			// 
			this.blueBar.Location = new System.Drawing.Point(287, 463);
			this.blueBar.Maximum = 255;
			this.blueBar.Name = "blueBar";
			this.blueBar.Size = new System.Drawing.Size(286, 17);
			this.blueBar.TabIndex = 14;
			this.blueBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueBar_Scroll);
			// 
			// colorLabel
			// 
			this.colorLabel.BackColor = System.Drawing.Color.Green;
			this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorLabel.Location = new System.Drawing.Point(576, 413);
			this.colorLabel.Name = "colorLabel";
			this.colorLabel.Size = new System.Drawing.Size(52, 67);
			this.colorLabel.TabIndex = 15;
			// 
			// SimpleEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 485);
			this.Controls.Add(this.colorLabel);
			this.Controls.Add(this.blueBar);
			this.Controls.Add(this.greenBar);
			this.Controls.Add(this.redBar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.uBtn);
			this.Controls.Add(this.iBtn);
			this.Controls.Add(this.bBtn);
			this.Controls.Add(this.sizeDropDown);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.fontFamilyBox);
			this.Controls.Add(this.label1);
			this.Name = "SimpleEditor";
			this.Text = "Editor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimpleEditor_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fontFamilyBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sizeDropDown;
        private System.Windows.Forms.Button bBtn;
        private System.Windows.Forms.Button iBtn;
        private System.Windows.Forms.Button uBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar redBar;
        private System.Windows.Forms.HScrollBar greenBar;
        private System.Windows.Forms.HScrollBar blueBar;
        private System.Windows.Forms.Label colorLabel;
    }
}