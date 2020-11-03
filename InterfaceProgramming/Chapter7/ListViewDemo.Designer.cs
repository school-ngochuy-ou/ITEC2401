namespace InterfaceProgramming.Chapter7 {
    partial class ListViewDemo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewDemo));
            this.harddriveComboBox = new System.Windows.Forms.ComboBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastAccessed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.largeIconRadioBtn = new System.Windows.Forms.RadioButton();
            this.smallIconRadioBtn = new System.Windows.Forms.RadioButton();
            this.listRadioBtn = new System.Windows.Forms.RadioButton();
            this.detailsRadioBtn = new System.Windows.Forms.RadioButton();
            this.titleRadioBtn = new System.Windows.Forms.RadioButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // harddriveComboBox
            // 
            this.harddriveComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.harddriveComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddriveComboBox.FormattingEnabled = true;
            this.harddriveComboBox.Location = new System.Drawing.Point(12, 12);
            this.harddriveComboBox.Name = "harddriveComboBox";
            this.harddriveComboBox.Size = new System.Drawing.Size(191, 26);
            this.harddriveComboBox.TabIndex = 0;
            this.harddriveComboBox.SelectedIndexChanged += new System.EventHandler(this.harddriveComboBox_SelectedIndexChanged);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryLabel.Location = new System.Drawing.Point(209, 15);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(27, 18);
            this.directoryLabel.TabIndex = 1;
            this.directoryLabel.Text = "D:\\";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Filename,
            this.Size,
            this.LastAccessed});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.Location = new System.Drawing.Point(12, 44);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(502, 335);
            this.listView.SmallImageList = this.imageList;
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // Filename
            // 
            this.Filename.Text = "Filename";
            // 
            // Size
            // 
            this.Size.Text = "Size";
            // 
            // LastAccessed
            // 
            this.LastAccessed.Text = "Last Accessed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.titleRadioBtn);
            this.groupBox1.Controls.Add(this.detailsRadioBtn);
            this.groupBox1.Controls.Add(this.listRadioBtn);
            this.groupBox1.Controls.Add(this.smallIconRadioBtn);
            this.groupBox1.Controls.Add(this.largeIconRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(524, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 335);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Mode";
            // 
            // largeIconRadioBtn
            // 
            this.largeIconRadioBtn.AutoSize = true;
            this.largeIconRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.largeIconRadioBtn.Location = new System.Drawing.Point(19, 47);
            this.largeIconRadioBtn.Name = "largeIconRadioBtn";
            this.largeIconRadioBtn.Size = new System.Drawing.Size(94, 22);
            this.largeIconRadioBtn.TabIndex = 0;
            this.largeIconRadioBtn.Text = "Large Icon";
            this.largeIconRadioBtn.UseVisualStyleBackColor = true;
            this.largeIconRadioBtn.CheckedChanged += new System.EventHandler(this.largeIconRadioBtn_CheckedChanged);
            // 
            // smallIconRadioBtn
            // 
            this.smallIconRadioBtn.AutoSize = true;
            this.smallIconRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smallIconRadioBtn.Location = new System.Drawing.Point(19, 101);
            this.smallIconRadioBtn.Name = "smallIconRadioBtn";
            this.smallIconRadioBtn.Size = new System.Drawing.Size(94, 22);
            this.smallIconRadioBtn.TabIndex = 1;
            this.smallIconRadioBtn.Text = "Small Icon";
            this.smallIconRadioBtn.UseVisualStyleBackColor = true;
            this.smallIconRadioBtn.CheckedChanged += new System.EventHandler(this.smallIconRadioBtn_CheckedChanged);
            // 
            // listRadioBtn
            // 
            this.listRadioBtn.AutoSize = true;
            this.listRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listRadioBtn.Location = new System.Drawing.Point(19, 155);
            this.listRadioBtn.Name = "listRadioBtn";
            this.listRadioBtn.Size = new System.Drawing.Size(48, 22);
            this.listRadioBtn.TabIndex = 2;
            this.listRadioBtn.Text = "List";
            this.listRadioBtn.UseVisualStyleBackColor = true;
            this.listRadioBtn.CheckedChanged += new System.EventHandler(this.listRadioBtn_CheckedChanged);
            // 
            // detailsRadioBtn
            // 
            this.detailsRadioBtn.AutoSize = true;
            this.detailsRadioBtn.Checked = true;
            this.detailsRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsRadioBtn.Location = new System.Drawing.Point(19, 209);
            this.detailsRadioBtn.Name = "detailsRadioBtn";
            this.detailsRadioBtn.Size = new System.Drawing.Size(70, 22);
            this.detailsRadioBtn.TabIndex = 3;
            this.detailsRadioBtn.TabStop = true;
            this.detailsRadioBtn.Text = "Details";
            this.detailsRadioBtn.UseVisualStyleBackColor = true;
            this.detailsRadioBtn.CheckedChanged += new System.EventHandler(this.detailsRadioBtn_CheckedChanged);
            // 
            // titleRadioBtn
            // 
            this.titleRadioBtn.AutoSize = true;
            this.titleRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleRadioBtn.Location = new System.Drawing.Point(19, 263);
            this.titleRadioBtn.Name = "titleRadioBtn";
            this.titleRadioBtn.Size = new System.Drawing.Size(52, 22);
            this.titleRadioBtn.TabIndex = 4;
            this.titleRadioBtn.Text = "Title";
            this.titleRadioBtn.UseVisualStyleBackColor = true;
            this.titleRadioBtn.CheckedChanged += new System.EventHandler(this.titleRadioBtn_CheckedChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder.jpg");
            this.imageList.Images.SetKeyName(1, "File-icon-by-ahlangraphic-6.jpg");
            // 
            // ListViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.harddriveComboBox);
            this.Name = "ListViewDemo";
            this.Text = "ListView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox harddriveComboBox;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Filename;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader LastAccessed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton titleRadioBtn;
        private System.Windows.Forms.RadioButton detailsRadioBtn;
        private System.Windows.Forms.RadioButton listRadioBtn;
        private System.Windows.Forms.RadioButton smallIconRadioBtn;
        private System.Windows.Forms.RadioButton largeIconRadioBtn;
        private System.Windows.Forms.ImageList imageList;
    }
}