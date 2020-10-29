namespace InterfaceProgramming.Chapter2 {
    partial class RandomNumberGeneratorGame {
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numberThree = new System.Windows.Forms.Label();
            this.numberTwo = new System.Windows.Forms.Label();
            this.numberOne = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(86, 226);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(118, 50);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(382, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 50);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numberThree
            // 
            this.numberThree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberThree.Location = new System.Drawing.Point(383, 9);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(166, 156);
            this.numberThree.TabIndex = 6;
            this.numberThree.Text = "0";
            this.numberThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberTwo
            // 
            this.numberTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTwo.Location = new System.Drawing.Point(211, 9);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(166, 156);
            this.numberTwo.TabIndex = 7;
            this.numberTwo.Text = "0";
            this.numberTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOne
            // 
            this.numberOne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOne.Location = new System.Drawing.Point(39, 9);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(166, 156);
            this.numberOne.TabIndex = 8;
            this.numberOne.Text = "0";
            this.numberOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.Location = new System.Drawing.Point(39, 177);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(510, 46);
            this.scoreBox.TabIndex = 9;
            this.scoreBox.Text = "0";
            this.scoreBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomNumberGeneratorGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 285);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberThree);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Name = "RandomNumberGeneratorGame";
            this.Text = "Random Number";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label numberThree;
        private System.Windows.Forms.Label numberTwo;
        private System.Windows.Forms.Label numberOne;
        private System.Windows.Forms.Label scoreBox;
    }
}