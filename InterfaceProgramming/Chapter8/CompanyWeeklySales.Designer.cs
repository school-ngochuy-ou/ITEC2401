namespace InterfaceProgramming.Chapter8 {
    partial class CompanyWeeklySales {
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
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mondayTextBox = new System.Windows.Forms.TextBox();
            this.tuesdayTextBox = new System.Windows.Forms.TextBox();
            this.wednesdayTextBox = new System.Windows.Forms.TextBox();
            this.thursdayTextBox = new System.Windows.Forms.TextBox();
            this.fridayTextBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.windowsToolStripMenuItem.Text = "Tools";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tuesday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wednesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thursday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Friday";
            // 
            // mondayTextBox
            // 
            this.mondayTextBox.Location = new System.Drawing.Point(25, 69);
            this.mondayTextBox.Name = "mondayTextBox";
            this.mondayTextBox.Size = new System.Drawing.Size(76, 20);
            this.mondayTextBox.TabIndex = 6;
            this.mondayTextBox.Text = "12000";
            // 
            // tuesdayTextBox
            // 
            this.tuesdayTextBox.Location = new System.Drawing.Point(139, 69);
            this.tuesdayTextBox.Name = "tuesdayTextBox";
            this.tuesdayTextBox.Size = new System.Drawing.Size(76, 20);
            this.tuesdayTextBox.TabIndex = 7;
            this.tuesdayTextBox.Text = "11000";
            // 
            // wednesdayTextBox
            // 
            this.wednesdayTextBox.Location = new System.Drawing.Point(263, 69);
            this.wednesdayTextBox.Name = "wednesdayTextBox";
            this.wednesdayTextBox.Size = new System.Drawing.Size(76, 20);
            this.wednesdayTextBox.TabIndex = 8;
            // 
            // thursdayTextBox
            // 
            this.thursdayTextBox.Location = new System.Drawing.Point(387, 69);
            this.thursdayTextBox.Name = "thursdayTextBox";
            this.thursdayTextBox.Size = new System.Drawing.Size(76, 20);
            this.thursdayTextBox.TabIndex = 9;
            // 
            // fridayTextBox
            // 
            this.fridayTextBox.Location = new System.Drawing.Point(499, 69);
            this.fridayTextBox.Name = "fridayTextBox";
            this.fridayTextBox.Size = new System.Drawing.Size(76, 20);
            this.fridayTextBox.TabIndex = 10;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(25, 98);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(550, 26);
            this.generateBtn.TabIndex = 11;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // CompanyWeeklySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 385);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.fridayTextBox);
            this.Controls.Add(this.thursdayTextBox);
            this.Controls.Add(this.wednesdayTextBox);
            this.Controls.Add(this.tuesdayTextBox);
            this.Controls.Add(this.mondayTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CompanyWeeklySales";
            this.Text = "Company Weekly Sales";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CompanyWeeklySales_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mondayTextBox;
        private System.Windows.Forms.TextBox tuesdayTextBox;
        private System.Windows.Forms.TextBox wednesdayTextBox;
        private System.Windows.Forms.TextBox thursdayTextBox;
        private System.Windows.Forms.TextBox fridayTextBox;
        private System.Windows.Forms.Button generateBtn;
    }
}