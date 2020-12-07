namespace InterfaceProgramming.Chapter4 {
    partial class CommonDialog {
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
			this.singleFileBtn = new System.Windows.Forms.Button();
			this.multipleFileBtn = new System.Windows.Forms.Button();
			this.folderPickBtn = new System.Windows.Forms.Button();
			this.bgColorBtn = new System.Windows.Forms.Button();
			this.colorDialogToggleBtn = new System.Windows.Forms.Button();
			this.fontPicker = new System.Windows.Forms.Button();
			this.resetBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.textBox = new System.Windows.Forms.RichTextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// singleFileBtn
			// 
			this.singleFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.singleFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.singleFileBtn.Location = new System.Drawing.Point(12, 12);
			this.singleFileBtn.Name = "singleFileBtn";
			this.singleFileBtn.Size = new System.Drawing.Size(158, 34);
			this.singleFileBtn.TabIndex = 0;
			this.singleFileBtn.Text = "Chọn một tập tin";
			this.singleFileBtn.UseVisualStyleBackColor = true;
			this.singleFileBtn.Click += new System.EventHandler(this.singleFileBtn_Click);
			// 
			// multipleFileBtn
			// 
			this.multipleFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.multipleFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multipleFileBtn.Location = new System.Drawing.Point(12, 52);
			this.multipleFileBtn.Name = "multipleFileBtn";
			this.multipleFileBtn.Size = new System.Drawing.Size(158, 34);
			this.multipleFileBtn.TabIndex = 1;
			this.multipleFileBtn.Text = "Chọn nhiều tập tin";
			this.multipleFileBtn.UseVisualStyleBackColor = true;
			this.multipleFileBtn.Click += new System.EventHandler(this.multipleFileBtn_Click);
			// 
			// folderPickBtn
			// 
			this.folderPickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.folderPickBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.folderPickBtn.Location = new System.Drawing.Point(12, 92);
			this.folderPickBtn.Name = "folderPickBtn";
			this.folderPickBtn.Size = new System.Drawing.Size(158, 34);
			this.folderPickBtn.TabIndex = 2;
			this.folderPickBtn.Text = "Chọn thư mục";
			this.folderPickBtn.UseVisualStyleBackColor = true;
			this.folderPickBtn.Click += new System.EventHandler(this.folderPickBtn_Click);
			// 
			// bgColorBtn
			// 
			this.bgColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bgColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bgColorBtn.Location = new System.Drawing.Point(12, 132);
			this.bgColorBtn.Name = "bgColorBtn";
			this.bgColorBtn.Size = new System.Drawing.Size(158, 34);
			this.bgColorBtn.TabIndex = 3;
			this.bgColorBtn.Text = "Chọn màu nền";
			this.bgColorBtn.UseVisualStyleBackColor = true;
			this.bgColorBtn.Click += new System.EventHandler(this.bgColorBtn_Click);
			// 
			// colorDialogToggleBtn
			// 
			this.colorDialogToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colorDialogToggleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorDialogToggleBtn.Location = new System.Drawing.Point(12, 172);
			this.colorDialogToggleBtn.Name = "colorDialogToggleBtn";
			this.colorDialogToggleBtn.Size = new System.Drawing.Size(158, 34);
			this.colorDialogToggleBtn.TabIndex = 4;
			this.colorDialogToggleBtn.Text = "Chọn màu chữ";
			this.colorDialogToggleBtn.UseVisualStyleBackColor = true;
			this.colorDialogToggleBtn.Click += new System.EventHandler(this.colorDialogToggle_Click);
			// 
			// fontPicker
			// 
			this.fontPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fontPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fontPicker.Location = new System.Drawing.Point(12, 212);
			this.fontPicker.Name = "fontPicker";
			this.fontPicker.Size = new System.Drawing.Size(158, 34);
			this.fontPicker.TabIndex = 5;
			this.fontPicker.Text = "Chọn font";
			this.fontPicker.UseVisualStyleBackColor = true;
			this.fontPicker.Click += new System.EventHandler(this.fontPicker_Click);
			// 
			// resetBtn
			// 
			this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetBtn.Location = new System.Drawing.Point(176, 212);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(158, 34);
			this.resetBtn.TabIndex = 6;
			this.resetBtn.Text = "Reset";
			this.resetBtn.UseVisualStyleBackColor = true;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBtn.Location = new System.Drawing.Point(340, 212);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(158, 34);
			this.exitBtn.TabIndex = 7;
			this.exitBtn.Text = "Thoát";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// textBox
			// 
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(176, 12);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(322, 194);
			this.textBox.TabIndex = 8;
			this.textBox.Text = "";
			// 
			// CommonDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 255);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.fontPicker);
			this.Controls.Add(this.colorDialogToggleBtn);
			this.Controls.Add(this.bgColorBtn);
			this.Controls.Add(this.folderPickBtn);
			this.Controls.Add(this.multipleFileBtn);
			this.Controls.Add(this.singleFileBtn);
			this.Name = "CommonDialog";
			this.Opacity = 0D;
			this.Text = "Common Dialog";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommonDialog_FormClosed);
			this.Load += new System.EventHandler(this.CommonDialog_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleFileBtn;
        private System.Windows.Forms.Button multipleFileBtn;
        private System.Windows.Forms.Button folderPickBtn;
        private System.Windows.Forms.Button bgColorBtn;
        private System.Windows.Forms.Button colorDialogToggleBtn;
        private System.Windows.Forms.Button fontPicker;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}