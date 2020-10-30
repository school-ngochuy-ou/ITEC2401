using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace InterfaceProgramming.Utils {

    enum Operator {
        ADD, SUBTRACT,
        DIVINE, MULTIPLY
    }

    class Fraction {

        public int numerator { get; set; }

        public int denominator { get; set; }

        public Fraction(int numer, int denom) {
            this.numerator = numer;
            this.denominator = denom;
        }

    }

    class NumberUtils {

        public Boolean isNumber(String val) {
            return val.All(Char.IsDigit);
        }

        public Boolean isAcceptableFloating(string input) {
            Regex reg = new Regex(@"^(-{1})?(\d+(\.{1})?)?$");

            return reg.Matches(input).Count == 1;
        }

        public Boolean isFloating(string input) {
            Regex reg = new Regex(@"^(-?){1}\d+((\.{1}\d+)?){1}$");

            return reg.Matches(input).Count == 1;
        }

        public String removeLeadingZeros(String input) {
            return input == "0" ? "0" : input.TrimStart(new Char[] { '0' } );
        }

        public Fraction[] equalizeDenominator(Fraction left, Fraction right) {
            int denominator = left.denominator * right.denominator;
            int aNumerator = left.numerator * right.denominator;
            int bNumerator = right.numerator * left.denominator;

            left.numerator = aNumerator;
            right.numerator = bNumerator;
            left.denominator = right.denominator = denominator;

            return new Fraction[] { left, right };
        }

        public int gcd(int a, int b) {
            if (a < b) {
                int t = a;

                a = b;
                b = t;
            }

            if (b == 0) {
                return a;
            }

            return gcd(b, a % b);
        }

        public Fraction simplizeFraction(Fraction f) {
            int gcd = this.gcd(Math.Abs(f.numerator), Math.Abs(f.denominator));

            return new Fraction(f.numerator / gcd, f.denominator / gcd);
        }

    }
}
