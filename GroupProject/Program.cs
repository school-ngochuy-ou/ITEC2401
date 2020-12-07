using System;
using System.Windows.Forms;
using GroupProject.forms;

namespace GroupProject {

    static class Program {

        public static DictionarySource dataSource = new DictionarySource();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VietnameseEnglishDictionary());
        }

    }
}
