namespace InterfaceProgramming.Chapter3 {
    partial class GuessTheResultGame {
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
			this.aNumer = new System.Windows.Forms.Label();
			this.aDenom = new System.Windows.Forms.Label();
			this.op = new System.Windows.Forms.Label();
			this.bDenom = new System.Windows.Forms.Label();
			this.bNumer = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.Label();
			this.rNumer = new System.Windows.Forms.TextBox();
			this.nextBtn = new System.Windows.Forms.Button();
			this.checkBtn = new System.Windows.Forms.Button();
			this.rDenom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(404, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Guess the result";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// aNumer
			// 
			this.aNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aNumer.Location = new System.Drawing.Point(12, 79);
			this.aNumer.Name = "aNumer";
			this.aNumer.Size = new System.Drawing.Size(83, 25);
			this.aNumer.TabIndex = 1;
			this.aNumer.Text = "0";
			this.aNumer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// aDenom
			// 
			this.aDenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aDenom.Location = new System.Drawing.Point(12, 128);
			this.aDenom.Name = "aDenom";
			this.aDenom.Size = new System.Drawing.Size(83, 25);
			this.aDenom.TabIndex = 2;
			this.aDenom.Text = "0";
			this.aDenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// op
			// 
			this.op.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.op.Location = new System.Drawing.Point(101, 106);
			this.op.Name = "op";
			this.op.Size = new System.Drawing.Size(52, 25);
			this.op.TabIndex = 3;
			this.op.Text = "+";
			this.op.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bDenom
			// 
			this.bDenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bDenom.Location = new System.Drawing.Point(159, 128);
			this.bDenom.Name = "bDenom";
			this.bDenom.Size = new System.Drawing.Size(83, 25);
			this.bDenom.TabIndex = 5;
			this.bDenom.Text = "0";
			this.bDenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bNumer
			// 
			this.bNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bNumer.Location = new System.Drawing.Point(159, 79);
			this.bNumer.Name = "bNumer";
			this.bNumer.Size = new System.Drawing.Size(83, 25);
			this.bNumer.TabIndex = 4;
			this.bNumer.Text = "0";
			this.bNumer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(248, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "=";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// result
			// 
			this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.result.Location = new System.Drawing.Point(17, 158);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(399, 36);
			this.result.TabIndex = 10;
			this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rNumer
			// 
			this.rNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rNumer.Location = new System.Drawing.Point(306, 83);
			this.rNumer.Name = "rNumer";
			this.rNumer.Size = new System.Drawing.Size(110, 23);
			this.rNumer.TabIndex = 11;
			this.rNumer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.rNumer.TextChanged += new System.EventHandler(this.rNumer_TextChanged);
			// 
			// nextBtn
			// 
			this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextBtn.Location = new System.Drawing.Point(83, 197);
			this.nextBtn.Name = "nextBtn";
			this.nextBtn.Size = new System.Drawing.Size(79, 40);
			this.nextBtn.TabIndex = 13;
			this.nextBtn.Text = "Next equation";
			this.nextBtn.UseVisualStyleBackColor = true;
			this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
			// 
			// checkBtn
			// 
			this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBtn.Location = new System.Drawing.Point(258, 197);
			this.checkBtn.Name = "checkBtn";
			this.checkBtn.Size = new System.Drawing.Size(79, 40);
			this.checkBtn.TabIndex = 14;
			this.checkBtn.Text = "Check";
			this.checkBtn.UseVisualStyleBackColor = true;
			this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
			// 
			// rDenom
			// 
			this.rDenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rDenom.Location = new System.Drawing.Point(306, 132);
			this.rDenom.Name = "rDenom";
			this.rDenom.Size = new System.Drawing.Size(110, 23);
			this.rDenom.TabIndex = 15;
			this.rDenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.rDenom.TextChanged += new System.EventHandler(this.rDenom_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "------";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(186, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "------";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(350, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "------";
			// 
			// GuessTheResultGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 245);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rDenom);
			this.Controls.Add(this.checkBtn);
			this.Controls.Add(this.nextBtn);
			this.Controls.Add(this.rNumer);
			this.Controls.Add(this.result);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bDenom);
			this.Controls.Add(this.bNumer);
			this.Controls.Add(this.op);
			this.Controls.Add(this.aDenom);
			this.Controls.Add(this.aNumer);
			this.Controls.Add(this.label1);
			this.Name = "GuessTheResultGame";
			this.Text = "s";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuessTheResultGame_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aNumer;
        private System.Windows.Forms.Label aDenom;
        private System.Windows.Forms.Label op;
        private System.Windows.Forms.Label bDenom;
        private System.Windows.Forms.Label bNumer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox rNumer;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox rDenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}