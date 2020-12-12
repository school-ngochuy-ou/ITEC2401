using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using GroupProject.models;

namespace GroupProject.forms {

	enum ViewState {
		CREATE, EDIT
	}

	public partial class WordView : Form {

		private ViewState state = ViewState.CREATE;

		private WordCollection parent;

		private Word word = new Word();

		private Dictionary<String, Word> dict;

		public WordView() {
			InitializeComponent();

			foreach (WordType type in Enum.GetValues(typeof(WordType))) {
				typeComboBox.Items.Add(type);
			}

			typeComboBox.SelectedItem = WordType.ADJECTIVE;

			foreach(Language language in Enum.GetValues(typeof(Language))) {
				languageComboBox.Items.Add(language);
			}

			listBox.DisplayMember = "name";
			listBox.ValueMember = "id";
		}

		private void nameTextBox_TextChanged(object sender, EventArgs e) {
			try {
				word.name = nameTextBox.Text;
			} catch (Exception) { }
		}

		private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			word.type = (WordType) typeComboBox.SelectedItem;
		}

		private void definitionTextBox_TextChanged(object sender, EventArgs e) {
			try {
				word.definition = definitionTextBox.Text;
			} catch(Exception) { }
		}

		private void cancelBtn_Click(object sender, EventArgs e) {
			Close();
		}

		public void setParent(WordCollection parent) {
			this.parent = parent;
		}

		internal void setState(ViewState state) {
			this.state = state;
			Text = state == ViewState.CREATE ? "New word" : "Edit word";
		}

		private void okBtn_Click(object sender, EventArgs e) {
			if (word.name.Length == 0 || word.definition.Length == 0) {
				MessageBox.Show("Word and it's definition can not be empty", "Error", MessageBoxButtons.OK);
				return;
			}

			if (parent != null) {
				if (state == ViewState.CREATE) {
					parent.addWord(word);
					Close();

					return;
				}

				parent.editWord(word);
			}

			Close();

			return;
		}

		internal void setWord(Word word) {
			this.word = word;
			renderWord();
		}

		private void renderWord() {
			nameTextBox.Text = word.name;
			typeComboBox.SelectedItem = word.type;
			definitionTextBox.Text = word.definition;
			/*translateChoiceTextBox.Text = word.translation == null ? "" : word.translation.name;*/
		}

		private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			listBox.Items.Clear();

			if (languageComboBox.SelectedItem == null) {
				dict = null;

				return;
			}

			Language language = (Language) languageComboBox.SelectedItem;

			dict = Program.store.getCollection(language);
			renderDictionary();
		}

		private void renderDictionary() {
			if (dict == null) {
				listBox.Items.Clear();

				return;
			}

			foreach (Word word in dict.Values) {
				listBox.Items.Add(word);
			}
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e) {
			if (listBox.SelectedItem == null) {
				return;
			}

			/*word.translation = listBox.SelectedItem as Word;*/
			translateChoiceTextBox.Text = (listBox.SelectedItem as Word).name;
		}

		private void searchTextBox_TextChanged(object sender, EventArgs e) {
			listBox.Items.Clear();

			if (languageComboBox.SelectedItem == null) {
				
				return;
			}

			String keyword = searchTextBox.Text;

			if (keyword.Length == 0) {
				dict = Program.store.getCollection((Language) languageComboBox.SelectedItem);
				renderDictionary();
				return;
			}

			foreach (Word word in dict.Values.Where(w => w.name.Contains(keyword))) {
				listBox.Items.Add(word);
			}
		}
	}

}
