using System;
using System.Windows.Forms;
using GroupProject.forms;
using GroupProject.models;

namespace GroupProject {

    static class Program {

        public static Storage store = new Storage();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

    }
}
