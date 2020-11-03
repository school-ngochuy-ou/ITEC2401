namespace InterfaceProgramming.Chapter6 {
    partial class RandomNumbers {
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
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.evenSumLabel = new System.Windows.Forms.Label();
            this.oddSumLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.elementsTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacity";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(95, 52);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(172, 24);
            this.numericUpDown.TabIndex = 2;
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(273, 46);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(87, 34);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Even sum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Odd sum";
            // 
            // evenSumLabel
            // 
            this.evenSumLabel.AutoSize = true;
            this.evenSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenSumLabel.Location = new System.Drawing.Point(92, 91);
            this.evenSumLabel.Name = "evenSumLabel";
            this.evenSumLabel.Size = new System.Drawing.Size(16, 18);
            this.evenSumLabel.TabIndex = 6;
            this.evenSumLabel.Text = "0";
            // 
            // oddSumLabel
            // 
            this.oddSumLabel.AutoSize = true;
            this.oddSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oddSumLabel.Location = new System.Drawing.Point(92, 126);
            this.oddSumLabel.Name = "oddSumLabel";
            this.oddSumLabel.Size = new System.Drawing.Size(16, 18);
            this.oddSumLabel.TabIndex = 7;
            this.oddSumLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Average";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(92, 162);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(16, 18);
            this.averageLabel.TabIndex = 9;
            this.averageLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Elements";
            // 
            // elementsTextBox
            // 
            this.elementsTextBox.Enabled = false;
            this.elementsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementsTextBox.Location = new System.Drawing.Point(95, 199);
            this.elementsTextBox.Name = "elementsTextBox";
            this.elementsTextBox.ReadOnly = true;
            this.elementsTextBox.Size = new System.Drawing.Size(265, 207);
            this.elementsTextBox.TabIndex = 11;
            this.elementsTextBox.Text = "";
            // 
            // PrimeStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 415);
            this.Controls.Add(this.elementsTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oddSumLabel);
            this.Controls.Add(this.evenSumLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrimeStat";
            this.Text = "PrimeStat";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label evenSumLabel;
        private System.Windows.Forms.Label oddSumLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox elementsTextBox;
    }
}