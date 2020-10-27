using System;
using System.Windows.Forms;
using InterfaceProgramming.Chapter2;

namespace InterfaceProgramming {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Chaper2Task1());
        }
    }
}
