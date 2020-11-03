using System;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter5 {
    public partial class BallGame : Form {

        private enum State {
            STOP, RUN
        }

        private State state = State.STOP;

        private Timer nextTimer;

        public BallGame() {
            InitializeComponent();
            nextTimer = ballDownTimer;
        }

        private void ballDownTimer_Tick(object sender, EventArgs e) {
            if (ball.Bottom < ClientRectangle.Height - bar.Height) {
                ball.Top += 10;
                return;
            }

            if (ball.Left > bar.Left + bar.Width || ball.Left + ball.Width < bar.Left) {
                ballDownTimer.Stop();
                MessageBox.Show("Game over", "Game over", MessageBoxButtons.OK);
                ball.Top = 0;
                return;
            }

            nextTimer = ballUpTimer;
            ballUpTimer.Start();
            ballDownTimer.Stop();
            return;
        }

        private void ballUpTimer_Tick(object sender, EventArgs e) {
            if (ball.Top > 0) {
                ball.Top -= 10;
                return;
            }

            nextTimer = ballDownTimer;
            ballUpTimer.Stop();
            ballDownTimer.Start();
            return;
        }

        private void BallGame_KeyDown(object sender, KeyEventArgs e) {
            switch(e.KeyCode) {
                case Keys.Right: {
                        if (state == State.STOP) {
                            break;
                        }

                        bar.Left += 5;
                        break;
                };
                case Keys.Left: {
                        if (state == State.STOP) {
                            break;
                        }

                        bar.Left -= 5;
                        break;
                };
                case Keys.S: {
                        if (state == State.STOP) {
                            nextTimer.Start();
                            state = State.RUN;
                            break;
                        }

                        nextTimer.Stop();
                        state = State.STOP;
                        break;
                }
            }
        }
    }
}
