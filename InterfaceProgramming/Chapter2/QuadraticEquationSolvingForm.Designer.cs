namespace InterfaceProgramming.Chapter2 {
    partial class QuadraticEquationSolvingForm {
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
			this.header = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.goButton = new System.Windows.Forms.Button();
			this.resultBox = new System.Windows.Forms.TextBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.cLabel = new System.Windows.Forms.Label();
			this.bLabel = new System.Windows.Forms.Label();
			this.aLabel = new System.Windows.Forms.Label();
			this.cInput = new System.Windows.Forms.TextBox();
			this.bInput = new System.Windows.Forms.TextBox();
			this.aInput = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// header
			// 
			this.header.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.header.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.header.Location = new System.Drawing.Point(12, 9);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(558, 48);
			this.header.TabIndex = 0;
			this.header.Text = "Quadratic Equation Solver";
			this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.exitButton);
			this.groupBox1.Controls.Add(this.goButton);
			this.groupBox1.Controls.Add(this.resultBox);
			this.groupBox1.Controls.Add(this.resultLabel);
			this.groupBox1.Controls.Add(this.cLabel);
			this.groupBox1.Controls.Add(this.bLabel);
			this.groupBox1.Controls.Add(this.aLabel);
			this.groupBox1.Controls.Add(this.cInput);
			this.groupBox1.Controls.Add(this.bInput);
			this.groupBox1.Controls.Add(this.aInput);
			this.groupBox1.Location = new System.Drawing.Point(12, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(558, 218);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(336, 155);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(111, 41);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "EXIT";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// goButton
			// 
			this.goButton.Location = new System.Drawing.Point(94, 155);
			this.goButton.Name = "goButton";
			this.goButton.Size = new System.Drawing.Size(111, 41);
			this.goButton.TabIndex = 8;
			this.goButton.Text = "GO";
			this.goButton.UseVisualStyleBackColor = true;
			this.goButton.Click += new System.EventHandler(this.goButton_Click);
			// 
			// resultBox
			// 
			this.resultBox.Enabled = false;
			this.resultBox.Location = new System.Drawing.Point(159, 89);
			this.resultBox.Multiline = true;
			this.resultBox.Name = "resultBox";
			this.resultBox.Size = new System.Drawing.Size(288, 40);
			this.resultBox.TabIndex = 7;
			this.resultBox.TabStop = false;
			this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// resultLabel
			// 
			this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLabel.Location = new System.Drawing.Point(91, 92);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(62, 37);
			this.resultLabel.TabIndex = 6;
			this.resultLabel.Text = "Result";
			this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cLabel
			// 
			this.cLabel.AutoSize = true;
			this.cLabel.Location = new System.Drawing.Point(396, 33);
			this.cLabel.Name = "cLabel";
			this.cLabel.Size = new System.Drawing.Size(19, 13);
			this.cLabel.TabIndex = 5;
			this.cLabel.Text = "c=";
			// 
			// bLabel
			// 
			this.bLabel.AutoSize = true;
			this.bLabel.Location = new System.Drawing.Point(210, 33);
			this.bLabel.Name = "bLabel";
			this.bLabel.Size = new System.Drawing.Size(19, 13);
			this.bLabel.TabIndex = 4;
			this.bLabel.Text = "b=";
			// 
			// aLabel
			// 
			this.aLabel.AutoSize = true;
			this.aLabel.Location = new System.Drawing.Point(6, 33);
			this.aLabel.Name = "aLabel";
			this.aLabel.Size = new System.Drawing.Size(19, 13);
			this.aLabel.TabIndex = 3;
			this.aLabel.Text = "a=";
			// 
			// cInput
			// 
			this.cInput.Location = new System.Drawing.Point(421, 30);
			this.cInput.Name = "cInput";
			this.cInput.Size = new System.Drawing.Size(131, 20);
			this.cInput.TabIndex = 2;
			this.cInput.TextChanged += new System.EventHandler(this.cInput_TextChanged);
			// 
			// bInput
			// 
			this.bInput.Location = new System.Drawing.Point(235, 30);
			this.bInput.Name = "bInput";
			this.bInput.Size = new System.Drawing.Size(131, 20);
			this.bInput.TabIndex = 1;
			this.bInput.TextChanged += new System.EventHandler(this.bInput_TextChanged);
			// 
			// aInput
			// 
			this.aInput.Location = new System.Drawing.Point(31, 30);
			this.aInput.Name = "aInput";
			this.aInput.Size = new System.Drawing.Size(131, 20);
			this.aInput.TabIndex = 0;
			this.aInput.TextChanged += new System.EventHandler(this.aInput_TextChanged);
			// 
			// QuadraticEquationSolvingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 297);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.header);
			this.Name = "QuadraticEquationSolvingForm";
			this.Text = "Quadratic Equation Solving";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuadraticEquationSolvingForm_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cInput;
        private System.Windows.Forms.TextBox bInput;
        private System.Windows.Forms.TextBox aInput;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button goButton;
    }
}