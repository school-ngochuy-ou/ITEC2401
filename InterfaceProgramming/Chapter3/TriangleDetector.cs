using InterfaceProgramming.Utils;
using System;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter3 {
    public partial class TriangleDetector : Form {

        private Triangle tri = new Triangle();

        private NumberUtils nu = new NumberUtils();

        private CursorUtils cUtils = new CursorUtils();

        public TriangleDetector() {
            InitializeComponent();
        }

        private void aSideInput_TextChanged(object sender, EventArgs e) {
            onSideChange('a', (TextBox) sender);
        }

        private void bSideInput_TextChanged(object sender, EventArgs e) {
            onSideChange('b', (TextBox) sender);
        }

        private void cSideInput_TextChanged(object sender, EventArgs e) {
            onSideChange('c', (TextBox) sender);
        }

        private void onSideChange(Char sideName, TextBox sender) {
            String val = sender.Text;
            val = nu.removeLeadingZeros(val);

            if (val.Length == 0) {
                sender.Text = "0";
                cUtils.cursorToEnd(sender);

                return;
            }

            if (!nu.isNumber(val)) {
                sender.Text = val.Substring(0, val.Length - 1);
                cUtils.cursorToEnd(sender);

                return;
            }

            switch (sideName) {
                case 'a': {
                        tri.a = int.Parse(val);
                        break;
                };
                case 'b': {
                        tri.b = int.Parse(val);
                        break;
                };
                case 'c': {
                        tri.c = int.Parse(val);
                        break;
                };
                default: {
                        break;
                };
            }

            sender.Text = val;
            cUtils.cursorToEnd(sender);

            return;
        }

        private void checkBtn_Click(object sender, EventArgs e) {
            String result = tri.isTriangle() ? "This is a triangle." : "This is not a triangle.";

            if (!tri.isTriangle()) {
                resultLabel.Text = result;

                return;
            }

            TriangleType type = tri.getTriangleType();

            result += $"\n{(type == TriangleType.NONE ? "This is not a special triangle." : $"This is a {type} triangle." )} ";
            result += $"\nHas the perimeter of {tri.getPerimeter()}.";
            result += $"\nAnd the area of {tri.getArea()}.";

            resultLabel.Text = result;
        }

        private void TriangleDetector_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }

    class Triangle {

        public int a { get; set; }

        public int b { get; set; }

        public int c { get; set; }

        public Boolean isTriangle() {
            return a + b > c ? a + c > b ? b + c > a : false : false;
        }

        public Boolean isRight() {

            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2);
        }

        public Boolean isEquilateral() {

            return a == b && b == c && a == c;
        }

        public Boolean isIsosceles() {

            return a == b || b == c || a == c;
        }

        public TriangleType getTriangleType() {

            return isRight() ? TriangleType.RIGHT : isEquilateral() ? TriangleType.EQUILATERAL : isIsosceles() ? TriangleType.ISOSCELES : TriangleType.NONE;
        }

        public int getPerimeter() {

            return a + b + c;
        }

        public double getArea() {

            return Math.Sqrt((a + b - c) * (a - b + c) * ((a * -1) + b + c) * (a + b + c)) / 4;
        }

    }

    enum TriangleType {
        RIGHT, EQUILATERAL, ISOSCELES, NONE
    }

}
