using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using GroupProject.models;

namespace GroupProject.forms {

	public partial class WordCollection : Form {

		private Dictionary<String, Word> dict;

		private Word word = new Word();

		private CollectionOption options = new CollectionOption();

		public WordCollection() {
			InitializeComponent();

			listBox.DisplayMember = "name";
			listBox.ValueMember = "id";

			foreach (Language lang in Enum.GetValues(typeof(Language))) {
				languageComboBox.Items.Add(lang);
			}

			languageComboBox.SelectedIndex = 0;
			options.language = (Language) languageComboBox.SelectedItem;
			options.keyword = "";
		}

		private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			options.language = (Language) languageComboBox.SelectedItem;
			dict = Program.store.getCollection(options.language);
			renderDictionary();
		}

		private void renderDictionary() {
			listBox.Items.Clear();

			if (dict.Count == 0) {
				messageLabel.Text = $"{options.language} word collection is empty";

				return;
			}

			messageLabel.Text = $"There are {dict.Count} word(s) in this collection";
			
			if (options.keyword.Length == 0) {
				foreach(Word word in dict.Values) {
					listBox.Items.Add(word);
				}

				return;
			}

			foreach(Word word in dict.Values.Where(w => w.name.Contains(options.keyword))) {
				listBox.Items.Add(word);
			}

			return;
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e) {
			word = listBox.SelectedItem as Word;
			renderRichTextBox();
		}

		private void renderRichTextBox() {
			if (word == null) {
				return;
			}

			richTextBox.Text = "";

			String content = $"{word.name}\n{word.type}\n\nDefinition: {word.definition}\n\n";

			int start = 0;

			richTextBox.Text = content;

			richTextBox.SelectionStart = start;
			richTextBox.SelectionLength = word.name.Length;
			richTextBox.SelectionColor = System.Drawing.Color.Black;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 30, System.Drawing.FontStyle.Bold);

			richTextBox.SelectionStart = (start += richTextBox.SelectionLength + 1);
			richTextBox.SelectionLength = word.type.ToString().Length;
			richTextBox.SelectionColor = System.Drawing.Color.Blue;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 10, System.Drawing.FontStyle.Italic);

			richTextBox.SelectionStart = (start += richTextBox.SelectionLength + 2);
			richTextBox.SelectionLength = 12;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 13, System.Drawing.FontStyle.Italic);

			richTextBox.SelectionStart = (start += 12);
			richTextBox.SelectionLength = word.definition.Length;
			richTextBox.SelectionColor = System.Drawing.Color.Black;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 13);

			richTextBox.SelectionStart = (start += richTextBox.SelectionLength + 2);
			richTextBox.SelectionLength = 9;
			richTextBox.SelectionFont = new System.Drawing.Font(richTextBox.SelectionFont.FontFamily, 13, System.Drawing.FontStyle.Italic);
		}

		private void searchTextBox_TextChanged(object sender, EventArgs e) {
			options.keyword = searchTextBox.Text;
		}

		private void searchBtn_Click(object sender, EventArgs e) {
			renderDictionary();
		}

		private void newWordBtn_Click(object sender, EventArgs e) {
			WordView view = new WordView();

			view.setParent(this);
			view.setState(ViewState.CREATE);
			view.ShowDialog();
		}

		internal void addWord(Word newWord) {
			Storage storage = Program.store;

			storage.addWord(options.language, newWord);
			listBox.SelectedItem = newWord;
			renderRichTextBox();
			renderDictionary();
		}

		internal void editWord(Word word) {
			Storage storage = Program.store;

			storage.editWord(options.language, word);
			listBox.SelectedItem = word;
			renderRichTextBox();
			renderDictionary();
		}

		private void editWordBtn_Click(object sender, EventArgs e) {
			if (listBox.SelectedItem == null) {
				return;
			}

			WordView view = new WordView();

			view.setWord(listBox.SelectedItem as Word);
			view.setState(ViewState.EDIT);
			view.setParent(this);
			view.ShowDialog();
		}

		private void deleteWordBtn_Click(object sender, EventArgs e) {
			if(listBox.SelectedItem == null) {
				return;
			}

			Word w = listBox.SelectedItem as Word;

			if (MessageBox.Show($"Are you sure you want do delete the word '{w.name}'?", "Confirm action", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				Storage store = Program.store;
				
				store.deleteWord(options.language, word);
				listBox.SelectedItem = dict.Values.First();
				renderRichTextBox();
				renderDictionary();
			}
		}
	}

	class CollectionOption {
		
		public Language language { get; set; }

		public String keyword { get; set; } = "";

	}

}
