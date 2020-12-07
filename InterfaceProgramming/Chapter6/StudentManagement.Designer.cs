namespace InterfaceProgramming.Chapter6 {
    partial class StudentManagement {
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
			this.listView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.idInput = new System.Windows.Forms.TextBox();
			this.firstNameInput = new System.Windows.Forms.TextBox();
			this.lastNameInput = new System.Windows.Forms.TextBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.messageLabel = new System.Windows.Forms.Label();
			this.keywordInput = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.sortBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Student Management";
			// 
			// listView
			// 
			this.listView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listView.Location = new System.Drawing.Point(12, 191);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(629, 247);
			this.listView.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Firstname";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "Lastname";
			// 
			// idInput
			// 
			this.idInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idInput.Location = new System.Drawing.Point(105, 62);
			this.idInput.Name = "idInput";
			this.idInput.Size = new System.Drawing.Size(253, 24);
			this.idInput.TabIndex = 5;
			this.idInput.TextChanged += new System.EventHandler(this.idInput_TextChanged);
			// 
			// firstNameInput
			// 
			this.firstNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameInput.Location = new System.Drawing.Point(105, 92);
			this.firstNameInput.Name = "firstNameInput";
			this.firstNameInput.Size = new System.Drawing.Size(253, 24);
			this.firstNameInput.TabIndex = 6;
			this.firstNameInput.TextChanged += new System.EventHandler(this.firstNameInput_TextChanged);
			// 
			// lastNameInput
			// 
			this.lastNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameInput.Location = new System.Drawing.Point(105, 122);
			this.lastNameInput.Name = "lastNameInput";
			this.lastNameInput.Size = new System.Drawing.Size(253, 24);
			this.lastNameInput.TabIndex = 7;
			this.lastNameInput.TextChanged += new System.EventHandler(this.lastNameInput_TextChanged);
			// 
			// addBtn
			// 
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.Location = new System.Drawing.Point(105, 152);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(109, 33);
			this.addBtn.TabIndex = 8;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// messageLabel
			// 
			this.messageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.messageLabel.AutoSize = true;
			this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageLabel.ForeColor = System.Drawing.Color.Red;
			this.messageLabel.Location = new System.Drawing.Point(220, 159);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(0, 17);
			this.messageLabel.TabIndex = 9;
			// 
			// keywordInput
			// 
			this.keywordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keywordInput.Location = new System.Drawing.Point(431, 62);
			this.keywordInput.Name = "keywordInput";
			this.keywordInput.Size = new System.Drawing.Size(210, 24);
			this.keywordInput.TabIndex = 10;
			this.keywordInput.TextChanged += new System.EventHandler(this.keywordInput_TextChanged);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(364, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 18);
			this.label5.TabIndex = 11;
			this.label5.Text = "Search";
			// 
			// sortBtn
			// 
			this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sortBtn.Location = new System.Drawing.Point(502, 152);
			this.sortBtn.Name = "sortBtn";
			this.sortBtn.Size = new System.Drawing.Size(139, 33);
			this.sortBtn.TabIndex = 12;
			this.sortBtn.Text = "Sort by lastname";
			this.sortBtn.UseVisualStyleBackColor = true;
			this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
			// 
			// StudentManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 450);
			this.Controls.Add(this.sortBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.keywordInput);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.lastNameInput);
			this.Controls.Add(this.firstNameInput);
			this.Controls.Add(this.idInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.label1);
			this.Name = "StudentManagement";
			this.Text = "StudentManagement";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentManagement_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox keywordInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sortBtn;
    }
}