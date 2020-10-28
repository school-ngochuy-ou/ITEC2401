using System;
using System.Text.RegularExpressions;

namespace InterfaceProgramming.Utils {
    class NumberUtils {

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

    }
}
