using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter4 {
    public partial class CommonDialog : Form {

        private FadeState fadeState = FadeState.IN;

        enum FadeState {
            IN, OUT
        }

        public CommonDialog() {
            InitializeComponent();
            ControlBox = false;
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) {
                fadeState = FadeState.OUT;
                timer.Start();
                return;
            }            
        }

        private void colorDialogToggle_Click(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                textBox.ForeColor = colorDialog.Color;
            }
        }

        private void bgColorBtn_Click(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                textBox.BackColor = colorDialog.Color;
            }
        }

        private void fontPicker_Click(object sender, EventArgs e) {
            if (fontDialog.ShowDialog() == DialogResult.OK) {
                textBox.Font = fontDialog.Font;
            }
        }

        private void CommonDialog_Load(object sender, EventArgs e) {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e) {
            if (fadeState == FadeState.IN) {
                if (Opacity < 1.0) {
                    Opacity += 0.25;
                    return;
                }

                timer.Stop();
                return;
            }

            if (Opacity > 0.0) {
                Opacity -= 0.25;
                return;
            }

            timer.Stop();
            this.Close();
        }

        private void singleFileBtn_Click(object sender, EventArgs e) {
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                textBox.Text = openFileDialog.FileName;
            }
        }

        private void multipleFileBtn_Click(object sender, EventArgs e) {
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                String[] filenames = openFileDialog.FileNames;
                String message = $"There are {filenames.Length} file(s):\n";

                foreach (String filename in filenames) {
                    message += $"{filename}\n";
                }

                textBox.Text = message;
            }
        }

        private void folderPickBtn_Click(object sender, EventArgs e) {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                textBox.Text = Path.GetFileName(folderBrowserDialog.SelectedPath);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e) {
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
            textBox.BackColor = Color.White;
        }

        private void CommonDialog_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }
}
