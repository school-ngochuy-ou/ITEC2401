using InterfaceProgramming.Chapter2;
using InterfaceProgramming.Chapter3;
using InterfaceProgramming.Chapter4;
using InterfaceProgramming.Chapter5;
using InterfaceProgramming.Chapter6;
using InterfaceProgramming.Chapter7;
using InterfaceProgramming.Chapter8;
using System.Windows.Forms;

namespace InterfaceProgramming {

    public partial class Menu : Form {

        public Menu() {
            InitializeComponent();
        }

        private void asciiBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new AsciiConverterForm().Show();
        }

        private void quadEquaBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new QuadraticEquationSolvingForm().Show();
        }

        private void jackpotBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new RandomNumberGeneratorGame().Show();
        }

        private void simpleCalBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new SimpleCalculator().Show();
        }

        private void fragtionBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new GuessTheResultGame().Show();
        }

        private void triangleBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new TriangleDetector().Show();
        }

        private void pointBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new CircleShape().Show();
        }

        private void ballBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new BallGame().Show();
        }

        private void comboListBoxBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new ComboListBox().Show();
        }

        private void simpleEditorBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new SimpleEditor().Show();
        }

        private void commonDialogBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new Chapter4.CommonDialog().Show();
        }

        private void myPhotoBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new MyPhotos().Show();
        }

        private void intArrayBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new RandomNumbers().Show();
        }

        private void studentArrayBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new StudentManagement().Show();
        }

        private void listViewDemoBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new ListViewDemo().Show();
        }

        private void drawChartBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new CompanyWeeklySales().Show();
        }

        private void drawShapeBtn_Click(object sender, System.EventArgs e) {
            Program.menuForm.Hide();

            new DrawShapes().Show();
        }
    }

}
