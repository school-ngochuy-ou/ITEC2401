using InterfaceProgramming.Utils;
using System;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter6 {
    public partial class RandomNumbers : Form {

        private int[] primes;

        public RandomNumbers() {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e) {
            int n = Convert.ToInt32(numericUpDown.Value);

            if (n == 0) {
                return;
            }

            Random rand = new Random();

            primes = new int[n];

            for (int i = 0; i < n; i++) {
                primes[i] = rand.Next(-100, 100);
            }

            int sumEven = this.sumEven();
            int sumOdd = this.sumOdd();
            double avg = this.avg();

            evenSumLabel.Text = sumEven.ToString();
            oddSumLabel.Text = sumOdd.ToString();
            averageLabel.Text = avg.ToString();
            elementsTextBox.Text = String.Join(", ", primes);
        }

        private double avg() {
            int n = primes.Length;
            int total = 0;

            for (int i = 0; i < n; i++) {
                total += primes[i];
            }

            return total / n;
        }

        private int sumOdd() {
            int n = primes.Length;
            int total = 0;

            for (int i = 0; i < n; i++) {
                if (primes[i] % 2 != 0) {
                    total += primes[i];
                }
            }

            return total;
        }

        private int sumEven() {
            int n = primes.Length;
            int total = 0;

            for (int i = 0; i < n; i++) {
                if (primes[i] % 2 == 0) {
                    total += primes[i];
                }
            }

            return total;
        }

        private void RandomNumbers_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }
}
