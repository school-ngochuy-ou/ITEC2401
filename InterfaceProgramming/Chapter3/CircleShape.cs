using InterfaceProgramming.Utils;
using System;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter3 {
    public partial class CircleShape : Form {

        private NumberUtils nu = new NumberUtils();

        private CursorUtils cursorUtils = new CursorUtils();

        private Circle circle = new Circle();

        private Point p = new Point(0, 0);

        public CircleShape() {
            InitializeComponent();
        }

        private void radiusInput_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox) sender;
            String val = nu.removeLeadingZeros(textBox.Text);

            if (val.Length == 0) {
                textBox.Text = "0";

                return;
            }

            if (!nu.isNumber(val)) {
                textBox.Text = val.Substring(0, val.Length - 1);
                cursorUtils.cursorToEnd(textBox);

                return;
            }

            circle.radius = double.Parse(val);
            textBox.Text = val;

            return;
        }

        private void onCordChange(String targetName, Char cordName, TextBox sender) {
            String val = sender.Text;
            val = nu.removeLeadingZeros(val);

            if (val.Length == 0) {
                sender.Text = "0";
                cursorUtils.cursorToEnd(sender);

                return;
            }

            if (!nu.isNumber(val)) {
                sender.Text = val.Substring(0, val.Length - 1);
                cursorUtils.cursorToEnd(sender);

                return;
            }

            switch (cordName) {
                case 'x': {
                        if (targetName == "circle") {
                            circle.centerPoint.x = int.Parse(val);
                            break;
                        }

                        p.x = int.Parse(val);
                        break;
                };
                case 'y': {
                        if (targetName == "circle") {
                            circle.centerPoint.y = int.Parse(val);
                            break;
                        }

                        p.y = int.Parse(val);
                        break;
                };
                default: {
                        break;
                };
            }

            sender.Text = val;
            cursorUtils.cursorToEnd(sender);

            return;
        }

        private void xCCordInput_TextChanged(object sender, EventArgs e) {
            onCordChange("circle", 'x', (TextBox) sender);
        }

        private void yCCordInput_TextChanged(object sender, EventArgs e) {
            onCordChange("circle", 'y', (TextBox) sender);
        }

        private void xPCord_TextChanged(object sender, EventArgs e) {
            onCordChange("point", 'x', (TextBox) sender);
        }

        private void yPCord_TextChanged(object sender, EventArgs e) {
            onCordChange("point", 'y', (TextBox) sender);
        }

        private void checkBtn_Click(object sender, EventArgs e) {
            String result = $"The point is {(circle.hasPoint(p) ? ("") : "not ")}in the circle.\n";

            result += $"The circle has the circumference of {circle.getCircumference()}.\n";
            result += $"The circle has the area of {circle.getArea()}.";
            resultLabel.Text = result;
        }

        private void CircleShape_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }

    class Point {

        public int x { get; set; }

        public int y { get; set; }

        public Point(int a, int b) {
            this.x = a;
            this.y = b;
        }

    }

    class Circle {

        public double radius { get; set; }

        public Point centerPoint { get; set; } = new Point(0, 0);

        public double getCircumference() {

            return 2 * Math.PI * radius;
        }

        public double getArea() {

            return Math.PI * Math.Pow(radius, 2);
        }

        public Boolean hasPoint(Point p) {

            return Math.Pow(Math.Abs(centerPoint.x - p.x), 2) + Math.Pow(Math.Abs(centerPoint.y - p.y), 2) <= Math.Pow(radius, 2);
        }

    }

}
