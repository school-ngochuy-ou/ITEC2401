using System.Windows.Forms;

namespace InterfaceProgramming.Utils {
    class CursorUtils {

        public void cursorToEnd(TextBox target) { 
            target.SelectionStart = target.Text.Length;
            target.SelectionLength = 0;
        }

    }
}
