using System;
using System.Windows.Forms;
using InterfaceProgramming.Chapter8;

namespace InterfaceProgramming {
    static class Program {
        
        public static Menu menuForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Menu menu = new Menu();

            Program.menuForm = menu;

            Application.Run(menu);
        }
    }
}
