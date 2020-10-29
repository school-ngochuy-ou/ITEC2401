using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter2 {
    public partial class SimpleCalculator : Form {

        private string equation = "";

        private string message = "";

        public SimpleCalculator() {
            InitializeComponent();
            renderEquation();
        }

        private void onValueButtonClick(string val) {

        }

        private void renderEquation() {
            equationBox.Text = equation;
        }

        private void renderMessage() {
            messageLabel.Text = message;
        }

        private void delBtn_Click(object sender, System.EventArgs e) {
            equation = "";
            renderEquation();
            message = "";
            renderMessage();
        }

        private void onSolveBtnClick(object sender, System.EventArgs e) {
            string val = equationBox.Text;
            Regex regex = new Regex(@"^\d+(\/|\*|\-|\+){1}\d+$");

            if (regex.Matches(val).Count == 0) {
                message = "Syntax error";
                renderMessage();
                return;
            }

            Regex leftValRegex = new Regex(@"(\/|\*|\-|\+){1}");
            string[] parts = leftValRegex.Split(val);
            double left = Double.Parse(parts[0]);
            char op = Char.Parse(parts[1]);
            double right = Double.Parse(parts[2]);

            switch (op) {
                case '+': {
                    equation += "=" + (left + right);
                    break;
                };
                case '-': {
                    equation += "=" + (left - right);
                    break;
                };
                case '*': {
                    equation += "=" + (left * right);
                    break;
                };
                default: {
                    if (right == 0) {
                        equation = "Can not divine by 0";
                            break;
                    }

                    equation += "=" + (left / right);
                    break;
                };
            }

            renderEquation();
        }

        private void equationElementClick(object sender, EventArgs e) {
            Button textBox = (Button) sender;

            equation += textBox.Text;
            renderEquation();
        }

        private void rBtn_Click(object sender, EventArgs e) {
            if (equation.Length == 0) {
                return;
            }

            equation = equation.Substring(0, equation.Length - 1);
            renderEquation();
            return;
        }
    }

}