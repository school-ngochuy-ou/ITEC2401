namespace InterfaceProgramming.Chapter4 {
    partial class ComboListBox {
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
            this.stringInput = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.leftListBox = new System.Windows.Forms.ListBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.toRightBtn = new System.Windows.Forms.Button();
            this.toLeftBtn = new System.Windows.Forms.Button();
            this.rightListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input a string";
            // 
            // stringInput
            // 
            this.stringInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringInput.Location = new System.Drawing.Point(12, 29);
            this.stringInput.Name = "stringInput";
            this.stringInput.Size = new System.Drawing.Size(251, 23);
            this.stringInput.TabIndex = 1;
            this.stringInput.TextChanged += new System.EventHandler(this.stringInput_TextChanged);
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(12, 55);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(90, 27);
            this.insertBtn.TabIndex = 2;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // leftListBox
            // 
            this.leftListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftListBox.FormattingEnabled = true;
            this.leftListBox.ItemHeight = 16;
            this.leftListBox.Location = new System.Drawing.Point(12, 88);
            this.leftListBox.Name = "leftListBox";
            this.leftListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.leftListBox.Size = new System.Drawing.Size(251, 324);
            this.leftListBox.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(269, 220);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(104, 27);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllBtn.Location = new System.Drawing.Point(269, 187);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(104, 27);
            this.clearAllBtn.TabIndex = 5;
            this.clearAllBtn.Text = "Clear all";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(269, 154);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(104, 27);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // toRightBtn
            // 
            this.toRightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRightBtn.Location = new System.Drawing.Point(269, 88);
            this.toRightBtn.Name = "toRightBtn";
            this.toRightBtn.Size = new System.Drawing.Size(104, 27);
            this.toRightBtn.TabIndex = 7;
            this.toRightBtn.Text = "==>";
            this.toRightBtn.UseVisualStyleBackColor = true;
            this.toRightBtn.Click += new System.EventHandler(this.toRightBtn_Click);
            // 
            // toLeftBtn
            // 
            this.toLeftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLeftBtn.Location = new System.Drawing.Point(269, 121);
            this.toLeftBtn.Name = "toLeftBtn";
            this.toLeftBtn.Size = new System.Drawing.Size(104, 27);
            this.toLeftBtn.TabIndex = 8;
            this.toLeftBtn.Text = "<==";
            this.toLeftBtn.UseVisualStyleBackColor = true;
            this.toLeftBtn.Click += new System.EventHandler(this.toLeftBtn_Click);
            // 
            // rightListBox
            // 
            this.rightListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightListBox.FormattingEnabled = true;
            this.rightListBox.ItemHeight = 16;
            this.rightListBox.Location = new System.Drawing.Point(379, 88);
            this.rightListBox.Name = "rightListBox";
            this.rightListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.rightListBox.Size = new System.Drawing.Size(251, 324);
            this.rightListBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select a color";
            // 
            // colorComboBox
            // 
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(379, 29);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(251, 24);
            this.colorComboBox.TabIndex = 11;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // ComboListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 428);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rightListBox);
            this.Controls.Add(this.toLeftBtn);
            this.Controls.Add(this.toRightBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.clearAllBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.leftListBox);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.stringInput);
            this.Controls.Add(this.label1);
            this.Name = "ComboListBox";
            this.Text = "ComboListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringInput;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.ListBox leftListBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button toRightBtn;
        private System.Windows.Forms.Button toLeftBtn;
        private System.Windows.Forms.ListBox rightListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox colorComboBox;
    }
}