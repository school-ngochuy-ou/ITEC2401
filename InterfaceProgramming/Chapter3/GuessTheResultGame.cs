using InterfaceProgramming.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter3 {

    public partial class GuessTheResultGame : Form {

        private FractionEquation equation = new FractionEquation();

        private Fraction rFraction = new Fraction(1, 2);

        private CursorUtils cursorUtils = new CursorUtils();

        private NumberUtils numberUtils = new NumberUtils();

        public GuessTheResultGame() {
            InitializeComponent();
            equation.randomNext();
            renderEquation();
        }

        private void renderEquation() {
            aNumer.Text = equation.a.numerator.ToString();
            aDenom.Text = equation.a.denominator.ToString();
            bNumer.Text = equation.b.numerator.ToString();
            bDenom.Text = equation.b.denominator.ToString();
            op.Text = equation.opString;
        }

        private void nextBtn_Click(object sender, EventArgs e) {
            equation.randomNext();
            renderEquation();
            rNumer.Text = "";
            rDenom.Text = "";
        }

        private void rNumer_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox) sender;
            String val = numberUtils.removeLeadingZeros(textBox.Text);

            if (val.Length == 0) {
                return;
            }

            if (!val.All(Char.IsDigit)) {
                textBox.Text = val.Substring(0, val.Length - 1);
                cursorUtils.cursorToEnd(textBox);

                return;
            }

            rFraction.numerator = int.Parse(val);
            textBox.Text = val;
            cursorUtils.cursorToEnd(textBox);
            
            return;
        }

        private void rDenom_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox) sender;
            String val = numberUtils.removeLeadingZeros(textBox.Text);

            if (val.Length == 0) {
                return;
            }

            if (!val.All(Char.IsDigit)) {
                textBox.Text = val.Substring(0, val.Length - 1);
                cursorUtils.cursorToEnd(textBox);

                return;
            }

            int denom = int.Parse(val);

            if (denom == 0) {
                textBox.Text = "1";
                cursorUtils.cursorToEnd(textBox);

                return;
            }

            rFraction.denominator = denom;
            textBox.Text = val;
            cursorUtils.cursorToEnd(textBox);

            return;
        }

        private void checkBtn_Click(object sender, EventArgs e) {
            Fraction resultFraction = FractionEquation.solveFractionEquation(equation.a, equation.b, equation.op);

            if (resultFraction.numerator == rFraction.numerator && resultFraction.denominator == rFraction.denominator) {
                result.Text = "Correct.";

                return;
            }

            result.Text = "Try again.";

            return;
        }

        private void GuessTheResultGame_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }

    class FractionEquation {

        public Fraction a { get; set; }

        public Fraction b { get; set; }

        public Operator op { get; set; } = Operator.ADD;

        public String opString = "+";

        private Operator[] opValues = new Operator[]{ Operator.ADD, Operator.SUBTRACT, Operator.DIVINE, Operator.MULTIPLY };

        public void randomNext() {
            Random rand = new Random();

            a = new Fraction(rand.Next(0, 10), rand.Next(1, 10));
            b = new Fraction(rand.Next(0, 10), rand.Next(1, 10));
            op = opValues[rand.Next(0, opValues.Length)];

            switch (op) {
                case Operator.ADD: {
                        opString = "+";
                        break;
                };
                case Operator.SUBTRACT: {
                        opString = "-";
                        break;
                };
                case Operator.DIVINE: {
                        opString = "/";
                        break;
                };
                case Operator.MULTIPLY: {
                        opString = "*";
                        break;
                };
                default: {
                        break;
                };
            }
        }

        public static Fraction solveFractionEquation(Fraction a, Fraction b, Operator op) {
            NumberUtils nu = new NumberUtils();

            switch (op) {
                case Operator.ADD: {
                    Fraction result;

                    if (a.denominator != b.denominator) {
                        Fraction[] ef = nu.equalizeDenominator(a, b);

                        result = new Fraction(ef[0].numerator + ef[1].numerator, ef[0].denominator);

                        return nu.simplizeFraction(result);
                    }

                    result = new Fraction(a.numerator + b.numerator, a.denominator);

                    return nu.simplizeFraction(result);
                };
                case Operator.SUBTRACT: {
                    Fraction result;

                    if (a.denominator != b.denominator) {
                        Fraction[] ef = nu.equalizeDenominator(a, b);

                        result = new Fraction(ef[0].numerator - ef[1].numerator, ef[0].denominator);

                        return nu.simplizeFraction(result);
                    }

                    result = new Fraction(a.numerator - b.numerator, a.denominator);

                    return nu.simplizeFraction(result);
                };
                case Operator.DIVINE: {
                    return nu.simplizeFraction(new Fraction(a.numerator * b.denominator, b.numerator * a.denominator));
                };
                case Operator.MULTIPLY: {
                    return nu.simplizeFraction(new Fraction(a.numerator * b.numerator, a.denominator * b.denominator));
                };
                default: {
                    return null;
                };
            }
        }

    }

}
