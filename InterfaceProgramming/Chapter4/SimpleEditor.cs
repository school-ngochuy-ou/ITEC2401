using InterfaceProgramming.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter4 {
    public partial class SimpleEditor : Form {

        private int rChannel = 0;

        private int gChannel = 0;

        private int bChannel = 0;

        private NumberUtils numberUtils = new NumberUtils();

        private Font selectionFont;
        
        private Font commonFont;

        private Dictionary<FontStyle, Boolean> fontStyles = new Dictionary<FontStyle, bool>();

        public SimpleEditor() {
            InitializeComponent();

            fontStyles.Add(FontStyle.Bold, Boolean.Parse("false"));
            fontStyles.Add(FontStyle.Italic, Boolean.Parse("false"));
            fontStyles.Add(FontStyle.Underline, Boolean.Parse("false"));

            foreach(FontFamily ff in FontFamily.Families) {
                fontFamilyBox.Items.Add(ff.Name);
            }

            for (int i = 2; i <= 72; i += 2) {
                sizeDropDown.Items.Add(i);
            }

            sizeDropDown.SelectedValue = "11";
            colorLabel.BackColor = Color.FromArgb(0, 0, 0);
            richTextBox.Text = @"'InterfaceProgramming.exe' (CLR v4.0.30319: InterfaceProgramming.exe): Loaded 'C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.";
            commonFont = richTextBox.Font;
            selectionFont = commonFont;
        }

        private void redBar_Scroll(object sender, ScrollEventArgs e) {
            HScrollBar bar = (HScrollBar) sender;

            rChannel = bar.Value;
            renderTextColor();
        }

        private void greenBar_Scroll(object sender, ScrollEventArgs e) {
            HScrollBar bar = (HScrollBar) sender;

            gChannel = bar.Value;
            renderTextColor();
        }

        private void blueBar_Scroll(object sender, ScrollEventArgs e) {
            HScrollBar bar = (HScrollBar) sender;

            bChannel = bar.Value;
            renderTextColor();
        }

        private void renderTextColor() {
            Color col = Color.FromArgb(rChannel, gChannel, bChannel);

            colorLabel.BackColor = col;
            richTextBox.SelectionColor = col;
        }

        private void sizeDropDown_TextChanged(object sender, EventArgs e) {
            ComboBox comboBox = (ComboBox)sender;
            String val = comboBox.Text;
            
            if (!numberUtils.isNumber(val)) {
                val = "11";
                sizeDropDown.Text = "11";
            }

            commonFont = new Font(commonFont.FontFamily, int.Parse(val), commonFont.Style);
            richTextBox.SelectionFont = commonFont;
        }

        private void bBtn_Click(object sender, EventArgs e) {
            changeRichTextFontStyle(FontStyle.Bold);
        }

        private void iBtn_Click(object sender, EventArgs e) {
            changeRichTextFontStyle(FontStyle.Italic);
        }

        private void uBtn_Click(object sender, EventArgs e) {
            changeRichTextFontStyle(FontStyle.Underline);
        }

        private void changeRichTextFontStyle(FontStyle style) {
            if (richTextBox.SelectionFont == null) {
                return;
            }

            switch(style) {
                case FontStyle.Bold: {
                        Boolean styleAdded = fontStyles[FontStyle.Bold] == false;
                        FontStyle styles = (styleAdded ? FontStyle.Bold : FontStyle.Regular) | (fontStyles[FontStyle.Italic] == true ? FontStyle.Italic : FontStyle.Regular) | (fontStyles[FontStyle.Underline] == true ? FontStyle.Underline : FontStyle.Regular);
                        
                        richTextBox.SelectionFont = new Font(selectionFont.FontFamily, selectionFont.Size, styles);
                        fontStyles[FontStyle.Bold] = styleAdded;
                        bBtn.FlatStyle = styleAdded ? FlatStyle.Flat : FlatStyle.Standard;

                        break;
                };
                case FontStyle.Italic: {
                        Boolean styleAdded = fontStyles[FontStyle.Italic] == false;
                        FontStyle styles = (fontStyles[FontStyle.Bold] == true ? FontStyle.Bold : FontStyle.Regular) | (styleAdded ? FontStyle.Italic : FontStyle.Regular) | (fontStyles[FontStyle.Underline] == true ? FontStyle.Underline : FontStyle.Regular);

                        richTextBox.SelectionFont = new Font(selectionFont.FontFamily, selectionFont.Size, styles);
                        fontStyles[FontStyle.Italic] = styleAdded;
                        iBtn.FlatStyle = styleAdded ? FlatStyle.Flat : FlatStyle.Standard;

                        break;
                };
                case FontStyle.Underline: {
                        Boolean styleAdded = fontStyles[FontStyle.Underline] == false;
                        FontStyle styles = (fontStyles[FontStyle.Bold] == true ? FontStyle.Bold : FontStyle.Regular) | (fontStyles[FontStyle.Italic] == true ? FontStyle.Italic : FontStyle.Regular) | (styleAdded ? FontStyle.Underline : FontStyle.Regular);

                        richTextBox.SelectionFont = new Font(selectionFont.FontFamily, selectionFont.Size, styles);
                        fontStyles[FontStyle.Underline] = styleAdded;
                        uBtn.FlatStyle = styleAdded ? FlatStyle.Flat : FlatStyle.Standard;

                        break;
                };
                default: {
                        break;
                }
            }
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e) {
            selectionFont = richTextBox.SelectionFont;

            if (selectionFont == null) {
                return;
            }

            String val = selectionFont.Style.ToString();

            val = Regex.Replace(val, @"\s+", "");

            FontStyle style;

            fontStyles = new Dictionary<FontStyle, bool>();
            fontStyles.Add(FontStyle.Bold, Boolean.Parse("false"));
            fontStyles.Add(FontStyle.Italic, Boolean.Parse("false"));
            fontStyles.Add(FontStyle.Underline, Boolean.Parse("false"));

            foreach (String s in val.Split(',')) {
                style = (FontStyle) Enum.Parse(typeof(FontStyle), s, true);    
                fontStyles[style] = true;
            }

            bBtn.FlatStyle = fontStyles[FontStyle.Bold] == false ? FlatStyle.Standard : FlatStyle.Flat;
            iBtn.FlatStyle = fontStyles[FontStyle.Italic] == false ? FlatStyle.Standard : FlatStyle.Flat;
            uBtn.FlatStyle = fontStyles[FontStyle.Underline] == false ? FlatStyle.Standard : FlatStyle.Flat;
        }

        private void fontFamilyBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                commonFont = new Font(fontFamilyBox.SelectedItem.ToString(), commonFont.Size, commonFont.Style);
                richTextBox.SelectionFont = commonFont;

            } catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void SimpleEditor_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }
}
