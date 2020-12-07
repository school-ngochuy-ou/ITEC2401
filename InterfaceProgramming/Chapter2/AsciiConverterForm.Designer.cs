namespace InterfaceProgramming.Chapter2 {
    partial class AsciiConverterForm {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.resultLabelOne = new System.Windows.Forms.Label();
			this.toCharButton = new System.Windows.Forms.Button();
			this.charResult = new System.Windows.Forms.TextBox();
			this.asciiCodeLabel = new System.Windows.Forms.Label();
			this.codeInput = new System.Windows.Forms.TextBox();
			this.codeResult = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.resultLabelTwo = new System.Windows.Forms.Label();
			this.toCodeButton = new System.Windows.Forms.Button();
			this.charLabel = new System.Windows.Forms.Label();
			this.charInput = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(9, 6);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10);
			this.label1.Size = new System.Drawing.Size(542, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "ASCII CONVERTER";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.resultLabelOne);
			this.groupBox1.Controls.Add(this.toCharButton);
			this.groupBox1.Controls.Add(this.charResult);
			this.groupBox1.Controls.Add(this.asciiCodeLabel);
			this.groupBox1.Controls.Add(this.codeInput);
			this.groupBox1.Location = new System.Drawing.Point(10, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 176);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ASCII to Character";
			// 
			// resultLabelOne
			// 
			this.resultLabelOne.AutoSize = true;
			this.resultLabelOne.Location = new System.Drawing.Point(6, 118);
			this.resultLabelOne.Name = "resultLabelOne";
			this.resultLabelOne.Size = new System.Drawing.Size(37, 13);
			this.resultLabelOne.TabIndex = 4;
			this.resultLabelOne.Text = "Result";
			// 
			// toCharButton
			// 
			this.toCharButton.Location = new System.Drawing.Point(127, 74);
			this.toCharButton.Name = "toCharButton";
			this.toCharButton.Size = new System.Drawing.Size(103, 30);
			this.toCharButton.TabIndex = 2;
			this.toCharButton.Text = "GO";
			this.toCharButton.UseVisualStyleBackColor = true;
			this.toCharButton.Click += new System.EventHandler(this.toCharButton_Click);
			// 
			// charResult
			// 
			this.charResult.Enabled = false;
			this.charResult.Location = new System.Drawing.Point(127, 115);
			this.charResult.Name = "charResult";
			this.charResult.Size = new System.Drawing.Size(103, 20);
			this.charResult.TabIndex = 4;
			// 
			// asciiCodeLabel
			// 
			this.asciiCodeLabel.AutoSize = true;
			this.asciiCodeLabel.Location = new System.Drawing.Point(6, 47);
			this.asciiCodeLabel.Name = "asciiCodeLabel";
			this.asciiCodeLabel.Size = new System.Drawing.Size(62, 13);
			this.asciiCodeLabel.TabIndex = 1;
			this.asciiCodeLabel.Text = "ASCII Code";
			// 
			// codeInput
			// 
			this.codeInput.Location = new System.Drawing.Point(127, 44);
			this.codeInput.Name = "codeInput";
			this.codeInput.Size = new System.Drawing.Size(103, 20);
			this.codeInput.TabIndex = 0;
			this.codeInput.TextChanged += new System.EventHandler(this.codeInput_TextChanged);
			// 
			// codeResult
			// 
			this.codeResult.Enabled = false;
			this.codeResult.Location = new System.Drawing.Point(134, 115);
			this.codeResult.Name = "codeResult";
			this.codeResult.Size = new System.Drawing.Size(103, 20);
			this.codeResult.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.resultLabelTwo);
			this.groupBox2.Controls.Add(this.codeResult);
			this.groupBox2.Controls.Add(this.toCodeButton);
			this.groupBox2.Controls.Add(this.charLabel);
			this.groupBox2.Controls.Add(this.charInput);
			this.groupBox2.Location = new System.Drawing.Point(286, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(270, 176);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Character to ASCII";
			// 
			// resultLabelTwo
			// 
			this.resultLabelTwo.AutoSize = true;
			this.resultLabelTwo.Location = new System.Drawing.Point(6, 118);
			this.resultLabelTwo.Name = "resultLabelTwo";
			this.resultLabelTwo.Size = new System.Drawing.Size(37, 13);
			this.resultLabelTwo.TabIndex = 5;
			this.resultLabelTwo.Text = "Result";
			// 
			// toCodeButton
			// 
			this.toCodeButton.Location = new System.Drawing.Point(134, 74);
			this.toCodeButton.Name = "toCodeButton";
			this.toCodeButton.Size = new System.Drawing.Size(103, 30);
			this.toCodeButton.TabIndex = 3;
			this.toCodeButton.Text = "GO";
			this.toCodeButton.UseVisualStyleBackColor = true;
			this.toCodeButton.Click += new System.EventHandler(this.toCodeButton_Click);
			// 
			// charLabel
			// 
			this.charLabel.AutoSize = true;
			this.charLabel.Location = new System.Drawing.Point(6, 47);
			this.charLabel.Name = "charLabel";
			this.charLabel.Size = new System.Drawing.Size(53, 13);
			this.charLabel.TabIndex = 2;
			this.charLabel.Text = "Character";
			// 
			// charInput
			// 
			this.charInput.Location = new System.Drawing.Point(134, 44);
			this.charInput.Name = "charInput";
			this.charInput.Size = new System.Drawing.Size(103, 20);
			this.charInput.TabIndex = 2;
			this.charInput.TextChanged += new System.EventHandler(this.charInput_TextChanged);
			// 
			// AsciiConverterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(563, 249);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Name = "AsciiConverterForm";
			this.Text = "TaskOne";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AsciiConverterForm_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox codeInput;
        private System.Windows.Forms.TextBox charInput;
        private System.Windows.Forms.Label asciiCodeLabel;
        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.Button toCharButton;
        private System.Windows.Forms.Button toCodeButton;
        private System.Windows.Forms.TextBox codeResult;
        private System.Windows.Forms.TextBox charResult;
        private System.Windows.Forms.Label resultLabelOne;
        private System.Windows.Forms.Label resultLabelTwo;
    }
}