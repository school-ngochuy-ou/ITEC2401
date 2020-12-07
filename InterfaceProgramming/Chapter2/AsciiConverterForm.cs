using InterfaceProgramming.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter2 {
    public partial class AsciiConverterForm : Form {

        private CursorUtils cursorUtils = new CursorUtils();

        private AsciiConverter converter;

        public AsciiConverterForm() {
            InitializeComponent();
            
            this.converter = new AsciiConverter(65, 'a');
            this.codeInput.Text = converter.code.ToString();
            this.charInput.Text = converter.character.ToString();
            this.codeResult.Text = converter.toCode().ToString();
            this.charResult.Text = converter.toChar().ToString();
        }

        private void codeInput_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox) sender;
            string textVal = textBox.Text.TrimStart(new Char[] { '0' } );
            
            if (textVal.Length == 0) {
                return;
            }

            if (!textVal.All(Char.IsDigit)) {
                textVal = "0";

                return;
            }

            double val = Double.Parse(textVal);

            if (val > Int32.MaxValue) {
                textBox.Text = "0";
                cursorUtils.cursorToEnd(textBox);

                return;
            }

            if (textVal.Length > 0) {
                this.converter.code = int.Parse(textVal);

                return;
            }
        }

        private void charInput_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox) sender;

            if (textBox.Text.Length > 1) {
                textBox.Text = textBox.Text.ElementAt(1).ToString();
                cursorUtils.cursorToEnd(textBox);
            }

            if (textBox.Text.Length > 0) {
                this.converter.character = Char.Parse(textBox.Text);
            }
        }

        private void toCharButton_Click(object sender, EventArgs e) {
            this.charResult.Text = this.converter.toChar().ToString(); 
        }

        private void toCodeButton_Click(object sender, EventArgs e) {
            this.codeResult.Text = "" + this.converter.toCode();
        }

        private void AsciiConverterForm_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }

    class AsciiConverter {

        public int code { get; set; }

        public char character { get; set; }

        public AsciiConverter(int code, char charracter) {
            this.code = code;
            this.character = character;
        }

        public int toCode() {
            try {
                return (int) this.character;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public char toChar() {
            try {
                return (char) this.code;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return ' ';
            }
        }

    }

}
