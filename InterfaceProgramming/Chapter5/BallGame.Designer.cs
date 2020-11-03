namespace InterfaceProgramming.Chapter5 {
    partial class BallGame {
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
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.Label();
            this.ballDownTimer = new System.Windows.Forms.Timer(this.components);
            this.ballUpTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = global::InterfaceProgramming.Properties.Resources.V200W_2;
            this.ball.Location = new System.Drawing.Point(245, 12);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(64, 62);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bar.Location = new System.Drawing.Point(214, 294);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(138, 30);
            this.bar.TabIndex = 1;
            // 
            // ballDownTimer
            // 
            this.ballDownTimer.Tick += new System.EventHandler(this.ballDownTimer_Tick);
            // 
            // ballUpTimer
            // 
            this.ballUpTimer.Tick += new System.EventHandler(this.ballUpTimer_Tick);
            // 
            // BallGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 324);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.ball);
            this.Name = "BallGame";
            this.Text = "BallGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BallGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label bar;
        private System.Windows.Forms.Timer ballDownTimer;
        private System.Windows.Forms.Timer ballUpTimer;
    }
}