using System;
using System.Windows.Forms;
using InterfaceProgramming.Chapter5;
using InterfaceProgramming.Chapter6;
using InterfaceProgramming.Utils;

namespace InterfaceProgramming {
    static class Program {

        public static CursorUtils cursorUtils = new CursorUtils();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RandomNumbers());
        }
    }
}
