﻿using System;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter2 {
    public partial class RandomNumberGeneratorGame : Form {

        private RandomNumberGenerator generator = new RandomNumberGenerator(0, 0 ,0);

        private int score = 0;

        public RandomNumberGeneratorGame() {
            InitializeComponent();
            renderNumbers();
            renderScore();
        }

        private void exitButton_Click(object sender, System.EventArgs e) {
            this.Close();
        }

        private void playButton_Click(object sender, System.EventArgs e) {
            generator.generateRandom();
            renderNumbers();
            score = generator.numbersAreEqual() ? score + 100 : score - 10;
            renderScore();
        }

        private void renderNumbers() {
            numberOne.Text = generator.a.ToString();
            numberTwo.Text = generator.b.ToString();
            numberThree.Text = generator.c.ToString();
        }

        private void renderScore() {
            scoreBox.Text = score.ToString();
        }

    }

    class RandomNumberGenerator {

        public int a { get; set; }

        public int b { get; set; }

        public int c { get; set; }

        public RandomNumberGenerator(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void generateRandom() {
            Random rand = new Random();

            this.a = rand.Next(0, 9);
            this.b = rand.Next(0, 9);
            this.c = rand.Next(0, 9);
        }

        public Boolean numbersAreEqual() {
            return a == b && b == c;
        }

    }

}
