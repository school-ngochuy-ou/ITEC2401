namespace InterfaceProgramming.Chapter3 {
    partial class TriangleDetector {
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
			this.label3 = new System.Windows.Forms.Label();
			this.aSideInput = new System.Windows.Forms.TextBox();
			this.bSideInput = new System.Windows.Forms.TextBox();
			this.cSideInput = new System.Windows.Forms.TextBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.checkBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "First edge";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Second edge";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "First edge";
			// 
			// aSideInput
			// 
			this.aSideInput.Location = new System.Drawing.Point(110, 8);
			this.aSideInput.Name = "aSideInput";
			this.aSideInput.Size = new System.Drawing.Size(100, 20);
			this.aSideInput.TabIndex = 3;
			this.aSideInput.TextChanged += new System.EventHandler(this.aSideInput_TextChanged);
			// 
			// bSideInput
			// 
			this.bSideInput.Location = new System.Drawing.Point(110, 36);
			this.bSideInput.Name = "bSideInput";
			this.bSideInput.Size = new System.Drawing.Size(100, 20);
			this.bSideInput.TabIndex = 4;
			this.bSideInput.TextChanged += new System.EventHandler(this.bSideInput_TextChanged);
			// 
			// cSideInput
			// 
			this.cSideInput.Location = new System.Drawing.Point(110, 64);
			this.cSideInput.Name = "cSideInput";
			this.cSideInput.Size = new System.Drawing.Size(100, 20);
			this.cSideInput.TabIndex = 5;
			this.cSideInput.TextChanged += new System.EventHandler(this.cSideInput_TextChanged);
			// 
			// resultLabel
			// 
			this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLabel.Location = new System.Drawing.Point(216, 8);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(270, 115);
			this.resultLabel.TabIndex = 6;
			// 
			// checkBtn
			// 
			this.checkBtn.Location = new System.Drawing.Point(12, 90);
			this.checkBtn.Name = "checkBtn";
			this.checkBtn.Size = new System.Drawing.Size(109, 34);
			this.checkBtn.TabIndex = 7;
			this.checkBtn.Text = "Check";
			this.checkBtn.UseVisualStyleBackColor = true;
			this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
			// 
			// TriangleDetector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 132);
			this.Controls.Add(this.checkBtn);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.cSideInput);
			this.Controls.Add(this.bSideInput);
			this.Controls.Add(this.aSideInput);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TriangleDetector";
			this.Text = "TriangleForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TriangleDetector_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aSideInput;
        private System.Windows.Forms.TextBox bSideInput;
        private System.Windows.Forms.TextBox cSideInput;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button checkBtn;
    }
}