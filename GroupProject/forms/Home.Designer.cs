
namespace GroupProject.forms {
	partial class Home {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
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
			this.vieEngBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "DICTIONARY";
			// 
			// vieEngBtn
			// 
			this.vieEngBtn.BackgroundImage = global::GroupProject.Properties.Resources.vie_en;
			this.vieEngBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.vieEngBtn.FlatAppearance.BorderSize = 0;
			this.vieEngBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.vieEngBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.vieEngBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.vieEngBtn.Location = new System.Drawing.Point(170, 99);
			this.vieEngBtn.Name = "vieEngBtn";
			this.vieEngBtn.Size = new System.Drawing.Size(80, 49);
			this.vieEngBtn.TabIndex = 2;
			this.vieEngBtn.UseVisualStyleBackColor = true;
			this.vieEngBtn.Click += new System.EventHandler(this.vieEngBtn_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(129, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Vietnamese - English";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(178, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Welcome";
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 265);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.vieEngBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Home";
			this.Text = "Home";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button vieEngBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}