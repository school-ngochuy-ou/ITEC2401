namespace InterfaceProgramming.Chapter3 {
    partial class CircleShape {
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
            this.radiusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiusInput = new System.Windows.Forms.TextBox();
            this.xCCordInput = new System.Windows.Forms.TextBox();
            this.yCCordInput = new System.Windows.Forms.TextBox();
            this.yPCord = new System.Windows.Forms.TextBox();
            this.xPCord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusLabel.Location = new System.Drawing.Point(12, 9);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(52, 17);
            this.radiusLabel.TabIndex = 0;
            this.radiusLabel.Text = "Radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Center X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Center Y";
            // 
            // radiusInput
            // 
            this.radiusInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusInput.Location = new System.Drawing.Point(108, 6);
            this.radiusInput.Name = "radiusInput";
            this.radiusInput.Size = new System.Drawing.Size(115, 23);
            this.radiusInput.TabIndex = 3;
            this.radiusInput.TextChanged += new System.EventHandler(this.radiusInput_TextChanged);
            // 
            // xCCordInput
            // 
            this.xCCordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCCordInput.Location = new System.Drawing.Point(108, 35);
            this.xCCordInput.Name = "xCCordInput";
            this.xCCordInput.Size = new System.Drawing.Size(115, 23);
            this.xCCordInput.TabIndex = 4;
            this.xCCordInput.TextChanged += new System.EventHandler(this.xCCordInput_TextChanged);
            // 
            // yCCordInput
            // 
            this.yCCordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCCordInput.Location = new System.Drawing.Point(108, 64);
            this.yCCordInput.Name = "yCCordInput";
            this.yCCordInput.Size = new System.Drawing.Size(115, 23);
            this.yCCordInput.TabIndex = 5;
            this.yCCordInput.TextChanged += new System.EventHandler(this.yCCordInput_TextChanged);
            // 
            // yPCord
            // 
            this.yPCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPCord.Location = new System.Drawing.Point(108, 122);
            this.yPCord.Name = "yPCord";
            this.yPCord.Size = new System.Drawing.Size(115, 23);
            this.yPCord.TabIndex = 9;
            this.yPCord.TextChanged += new System.EventHandler(this.yPCord_TextChanged);
            // 
            // xPCord
            // 
            this.xPCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPCord.Location = new System.Drawing.Point(108, 93);
            this.xPCord.Name = "xPCord";
            this.xPCord.Size = new System.Drawing.Size(115, 23);
            this.xPCord.TabIndex = 8;
            this.xPCord.TextChanged += new System.EventHandler(this.xPCord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Point Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Point X";
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Location = new System.Drawing.Point(229, 6);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(109, 23);
            this.checkBtn.TabIndex = 10;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(229, 35);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(259, 110);
            this.resultLabel.TabIndex = 11;
            // 
            // CircleShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 164);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.radiusInput);
            this.Controls.Add(this.yPCord);
            this.Controls.Add(this.xPCord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yCCordInput);
            this.Controls.Add(this.xCCordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radiusLabel);
            this.Name = "CircleShape";
            this.Text = "CircleShape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox radiusInput;
        private System.Windows.Forms.TextBox xCCordInput;
        private System.Windows.Forms.TextBox yCCordInput;
        private System.Windows.Forms.TextBox yPCord;
        private System.Windows.Forms.TextBox xPCord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label resultLabel;
    }
}