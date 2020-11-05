using InterfaceProgramming.Utils;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter8 {
    public partial class CompanyWeeklySales : Form {

        private NumberUtils nu = new NumberUtils();

        private int maxChartHeight = 230;

        private int textBoxWidth = 76;

        private int paddingBottom = 50;

        private Rectangle[] rects = new Rectangle[5];

        public CompanyWeeklySales() {
            InitializeComponent();
        }

        private void CompanyWeeklySales_Paint(object sender, PaintEventArgs e) {
            Pen pen = new Pen(Color.Black, 2);
            float x1 = mondayTextBox.Location.X, y1 = this.Height - 50;
            float x2 = fridayTextBox.Location.X + fridayTextBox.Size.Width, y2 = this.Height - 50;
            
            e.Graphics.DrawLine(pen, x1, y1, x2, y2);

            Brush brush = new SolidBrush(Color.Red);

            e.Graphics.FillRectangle(brush, rects[0]);
            brush = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(brush, rects[1]);
            brush = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(brush, rects[2]);
            brush = new SolidBrush(Color.Yellow);
            e.Graphics.FillRectangle(brush, rects[3]);
            brush = new SolidBrush(Color.Aqua);
            e.Graphics.FillRectangle(brush, rects[4]);
        }

        private void generateBtn_Click(object sender, System.EventArgs e) {
            String[] values = new String[] {
                mondayTextBox.Text, tuesdayTextBox.Text,
                wednesdayTextBox.Text, thursdayTextBox.Text,
                fridayTextBox.Text
            };
            bool valid = values.All(nu.isNumber);

            if (!valid) {
                return;
            }

            float[] vals = new float[] {
                float.Parse(values[0]), float.Parse(values[1]),
                float.Parse(values[2]), float.Parse(values[3]),
                float.Parse(values[4])
            };
            float maxVal = vals.Max();
            int[] proportions = new int[] {
                (int) ((vals[0] / maxVal) * maxChartHeight),
                (int) ((vals[1] / maxVal) * maxChartHeight),
                (int) ((vals[2] / maxVal) * maxChartHeight),
                (int) ((vals[3] / maxVal) * maxChartHeight),
                (int) ((vals[4] / maxVal) * maxChartHeight),
            };

            rects = new Rectangle[5];

            int y = this.Height - (paddingBottom + maxChartHeight);

            rects[0] = new Rectangle(mondayTextBox.Location.X, y + (maxChartHeight - proportions[0]), textBoxWidth, proportions[0]);
            rects[1] = new Rectangle(tuesdayTextBox.Location.X, y + (maxChartHeight - proportions[1]), textBoxWidth, proportions[1]);
            rects[2] = new Rectangle(wednesdayTextBox.Location.X, y + (maxChartHeight - proportions[2]), textBoxWidth, proportions[2]);
            rects[3] = new Rectangle(thursdayTextBox.Location.X, y + (maxChartHeight - proportions[3]), textBoxWidth, proportions[3]);
            rects[4] = new Rectangle(fridayTextBox.Location.X, y + (maxChartHeight - proportions[4]), textBoxWidth, proportions[4]);
            this.Refresh();
        }
    }
}
