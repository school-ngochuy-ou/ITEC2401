using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter8 {
    public partial class ShapeOption : Form {

        private DrawShapes parent;
        
        private Color color = Color.Red;

        private Shape shape = Shape.RECTANGLE;

        public ShapeOption() {
            InitializeComponent();
        }

        public void setParent(DrawShapes parent) {
            this.parent = parent;
        }

        private void colorPickBtn_Click(object sender, EventArgs e) {
            if (colorPicker.ShowDialog() == DialogResult.OK) {
                color = colorPicker.Color;
                colorPickBtn.BackColor = color;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void okBtn_Click(object sender, EventArgs e) {
            parent.setOption(new DrawOption(color, shape));

            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            shape = Shape.RECTANGLE;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            shape = Shape.ELLIPSE;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            shape = Shape.TRIANGLE;
        }
    }
}
