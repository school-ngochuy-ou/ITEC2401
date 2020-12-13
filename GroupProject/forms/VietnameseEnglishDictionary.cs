using GroupProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GroupProject.forms {

	public partial class VietnameseEnglishDictionary : Form {

		private Dictionary<String, Word> dict;

		private Language targetLanguage;

		public VietnameseEnglishDictionary() {
			InitializeComponent();

			listBox.ValueMember = "id";
			listBox.DisplayMember = "name";
			rdBtn_CheckedChanged(searchEnglishRdBtn, null);
		}

		private void collectionToolStripMenuItem_Click(object sender, System.EventArgs e) {
			new WordCollection().Show();
		}

		private void rdBtn_CheckedChanged(object sender, EventArgs e) {
			if (searchVietnameseRdBtn.Checked) {
				dict = Program.store.getCollection(Language.Vietnamese);
				targetLanguage = Language.English;
				renderDictionary();

				return;
			}

			if (searchEnglishRdBtn.Checked) {
				dict = Program.store.getCollection(Language.English);
				targetLanguage = Language.Vietnamese;
				renderDictionary();

				return;
			}
		}

		private void renderDictionary() {
			listBox.Items.Clear();

			foreach(Word word in dict.Values) {
				listBox.Items.Add(word);
			}
		}

		private void searchTextBox_TextChanged(object sender, EventArgs e) {
			String keyword;

			if ((keyword = searchTextBox.Text).Length == 0) {
				renderDictionary();
				return;
			}

			listBox.Items.Clear();

			foreach(Word word in dict.Values.Where(w => w.name.Contains(keyword))) {
				listBox.Items.Add(word);
			}
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e) {
			if (listBox.SelectedItem == null) {
				return;
			}

			Word word = listBox.SelectedItem as Word;

			panel.Controls.Clear();

			if (!word.translationCollection.ContainsKey(targetLanguage)) {
				String message = "No translations found";
				RichTextBox textBox = new RichTextBox() {
					ReadOnly = true,
					Width = panel.Width,
					Height = panel.Height
				};

				textBox.Text = message;
				textBox.SelectionStart = 0;
				textBox.SelectionLength = message.Length;
				textBox.SelectionColor = System.Drawing.Color.Red;
				textBox.SelectionFont = new System.Drawing.Font(textBox.SelectionFont.FontFamily, 20, System.Drawing.FontStyle.Bold);
				panel.Controls.Add(textBox);

				return;
			}

			int index = 0;

			foreach (Word translation in word.translationCollection[targetLanguage].Values) {
				panel.Controls.Add(getRichTextBox(translation, index++));
			}
		}

		private RichTextBox getRichTextBox(Word translation, int index) {
			RichTextBox richTextBox = new RichTextBox() {
				ReadOnly = true,
				Top = 200 * index,
				Width = panel.Width,
				Height = 200,
				Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right)
			};
			int start = 0;

			richTextBox.Text += $"{translation.name}\n{translation.type}\n\nDefinition: {translation.definition}\n\n";

			richTextBox.SelectionStart = start;
			richTextBox.SelectionLength = translation.name.Length;
			richTextBox.SelectionColor = System.Drawing.Color.Black;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 30, System.Drawing.FontStyle.Bold);

			richTextBox.SelectionStart = (start += richTextBox.SelectionLength + 1);
			richTextBox.SelectionLength = translation.type.ToString().Length;
			richTextBox.SelectionColor = System.Drawing.Color.Blue;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 10, System.Drawing.FontStyle.Italic);

			richTextBox.SelectionStart = (start += richTextBox.SelectionLength + 2);
			richTextBox.SelectionLength = 12;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 13, System.Drawing.FontStyle.Italic);

			richTextBox.SelectionStart = (start += 12);
			richTextBox.SelectionLength = translation.definition.Length;
			richTextBox.SelectionColor = System.Drawing.Color.Black;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 13);

			richTextBox.SelectionStart = (start += richTextBox.SelectionLength + 2);
			richTextBox.SelectionLength = 9;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 13, System.Drawing.FontStyle.Italic);

			return richTextBox;
		}

		private void VietnameseEnglishDictionary_FormClosed(object sender, FormClosedEventArgs e) {
			Program.home.Show();
		}
	}

}
