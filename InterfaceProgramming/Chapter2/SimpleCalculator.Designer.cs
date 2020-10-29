namespace InterfaceProgramming.Chapter2 {
    partial class SimpleCalculator {
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
            this.equationBox = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.rBtn = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equationBox
            // 
            this.equationBox.Enabled = false;
            this.equationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equationBox.Location = new System.Drawing.Point(12, 45);
            this.equationBox.Multiline = true;
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(264, 40);
            this.equationBox.TabIndex = 1;
            this.equationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.equationBox.WordWrap = false;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(12, 104);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(80, 32);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "DEL";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // rBtn
            // 
            this.rBtn.Location = new System.Drawing.Point(196, 104);
            this.rBtn.Name = "rBtn";
            this.rBtn.Size = new System.Drawing.Size(80, 32);
            this.rBtn.TabIndex = 3;
            this.rBtn.Text = "R";
            this.rBtn.UseVisualStyleBackColor = true;
            this.rBtn.Click += new System.EventHandler(this.rBtn_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 155);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(57, 32);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.equationElementClick);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(75, 155);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(57, 32);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.equationElementClick);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(138, 155);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(57, 32);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.equationElementClick);
            // 
            // divine
            // 
            this.divine.Location = new System.Drawing.Point(201, 155);
            this.divine.Name = "divine";
            this.divine.Size = new System.Drawing.Size(75, 32);
            this.divine.TabIndex = 7;
            this.divine.Text = "/";
            this.divine.UseVisualStyleBackColor = true;
            this.divine.Click += new System.EventHandler(this.equationElementClick);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 193);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(57, 32);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.equationElementClick);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(75, 193);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(57, 32);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.equationElementClick);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(138, 193);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(57, 32);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.equationElementClick);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(201, 193);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 32);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.equationElementClick);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 231);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(57, 32);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.equationElementClick);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(75, 231);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(57, 32);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.equationElementClick);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(138, 231);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(57, 32);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.equationElementClick);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(201, 231);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(75, 32);
            this.subtract.TabIndex = 15;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.equationElementClick);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 269);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(57, 32);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.equationElementClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(75, 269);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 32);
            this.button14.TabIndex = 17;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.onSolveBtnClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(201, 269);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 32);
            this.add.TabIndex = 18;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.equationElementClick);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(98, 104);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(92, 32);
            this.messageLabel.TabIndex = 19;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 309);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divine);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.rBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.equationBox);
            this.Controls.Add(this.label1);
            this.Name = "SimpleCalculator";
            this.Text = "SimpleCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox equationBox;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button rBtn;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button divine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label messageLabel;
    }
}