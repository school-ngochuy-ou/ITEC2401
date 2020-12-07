using InterfaceProgramming.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter2 {
    public partial class QuadraticEquationSolvingForm : Form {

        private CursorUtils cursorUtils = new CursorUtils();

        private NumberUtils numberUtils = new NumberUtils();

        private QuadraticEquationSolver solver = new QuadraticEquationSolver();

        public QuadraticEquationSolvingForm() {
            InitializeComponent();
            renderInputs();
        }

        private void renderInputs() {
            this.aInput.Text = solver.a.ToString();
            this.bInput.Text = solver.b.ToString();
            this.cInput.Text = solver.c.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void aInput_TextChanged(object sender, EventArgs e) {
            onInputChange(sender, e, (val) => {
                solver.a = Double.Parse(val);

                return val;
            });
        }

        private void bInput_TextChanged(object sender, EventArgs e) {
            onInputChange(sender, e, (val) => {
                solver.b = Double.Parse(val);

                return val;
            });
        }

        private void cInput_TextChanged(object sender, EventArgs e) {
            onInputChange(sender, e, (val) => {
                solver.c = Double.Parse(val);

                return val;
            });
        }

        private void onInputChange(object sender, EventArgs e, Func<String, String> func) {
            TextBox textBox = (TextBox) sender;
            String val = textBox.Text;

            if (val.Length == 0) {
                return;
            }

            if (!numberUtils.isFloating(val)) {
                if (!numberUtils.isAcceptableFloating(val)) {
                    textBox.Text = "0";
                    cursorUtils.cursorToEnd(textBox);

                    return;
                }

                return;
            }

            textBox.Text = numberUtils.removeLeadingZeros(val);
            cursorUtils.cursorToEnd(textBox);
            func.Invoke(val);
        }

        private void goButton_Click(object sender, EventArgs e) {
            SolverResult result = solver.solve();

            switch (result.type) {
                case SolverResult.ResultType.NAN: {
                        resultBox.Text = "No solution";
                        resultBox.Font = new Font(resultBox.Font.FontFamily, 15);
                        return;
                    };
                case SolverResult.ResultType.INF: {
                        resultBox.Text = "Infinite solution";
                        resultBox.Font = new Font(resultBox.Font.FontFamily, 15);
                        return;
                    };
                case SolverResult.ResultType.SINGULAR: {
                        resultBox.Text = $"x= {result.a}";
                        resultBox.Font = new Font(resultBox.Font.FontFamily, 15);
                        return;
                    };
                case SolverResult.ResultType.PAIRED: {
                        resultBox.Text = $"x1= {result.a}";
                        resultBox.AppendText(Environment.NewLine);
                        resultBox.AppendText($"x2= {result.b}");
                        resultBox.Font = new Font(resultBox.Font.FontFamily, 10);
                        return;
                    };
                default:
                    return;
            }
        }

        private void QuadraticEquationSolvingForm_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }

    class QuadraticEquationSolver {

        public double a { get; set; }

        public double b { get; set; }

        public double c { get; set; }

        public QuadraticEquationSolver() {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public SolverResult solve() {
            if (a == 0) {
                if (b == 0) {
                    return new SolverResult(0, 0, SolverResult.ResultType.NAN);
                }

                if (c == 0) {
                    return new SolverResult(0, 0, SolverResult.ResultType.INF);
                }

                return new SolverResult(-c / b, -c / b, SolverResult.ResultType.SINGULAR);
            }

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0) {
                return new SolverResult(0, 0, SolverResult.ResultType.NAN);
            }

            if (delta == 0) {
                return new SolverResult(-b / 2 * a, -b / 2 * a, SolverResult.ResultType.SINGULAR);
            }

            return new SolverResult((-b + Math.Sqrt(delta)) / (2 * a), (-b - Math.Sqrt(delta)) / (2 * a), SolverResult.ResultType.PAIRED);
        }

    }

    class SolverResult {

        public enum ResultType {
            NAN, INF, PAIRED, SINGULAR
        } 

        public double a { get; set; }

        public double b { get; set; }

        public ResultType type { get; set; }

        public SolverResult(double a, double b, ResultType type) {
            this.a = a;
            this.b = b;
            this.type = type;
        }

    }

}
