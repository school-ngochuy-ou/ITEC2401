using System;
using System.Windows.Forms;
using System.Collections.Generic;
using GroupProject.models;
using System.Linq;

namespace GroupProject.forms {

	enum ViewState {
		CREATE, EDIT
	}

	public partial class WordView : Form {

		private ViewState state = ViewState.CREATE;

		private WordCollection parent;

		private Word word = new Word();

		private Dictionary<String, Word> dict;
		
		private Language targetLanguage;

		public WordView() {
			InitializeComponent();

			foreach (WordType type in Enum.GetValues(typeof(WordType))) {
				typeComboBox.Items.Add(type);
			}

			typeComboBox.SelectedItem = WordType.ADJECTIVE;

			foreach(Language language in Enum.GetValues(typeof(Language))) {
				languageComboBox.Items.Add(language);
			}

			sourceListBox.ValueMember = "id";
			sourceListBox.DisplayMember = "name";
			translationListBox.ValueMember = "id";
			translationListBox.DisplayMember = "name";
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
		}

		private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			if (languageComboBox.SelectedItem == null) {
				dict = null;

				return;
			}

			dict = Program.store.getCollection(targetLanguage = (Language) languageComboBox.SelectedItem);
			renderSourceListBox();
			renderTranslationListBox();
		}

		private void renderSourceListBox() {
			sourceListBox.Items.Clear();

			foreach(Word word in dict.Values) {
				sourceListBox.Items.Add(word);
			}
		}

		private void renderTranslationListBox() {
			translationListBox.Items.Clear();

			if (!word.translationCollection.ContainsKey(targetLanguage)) {
				return;
			}

			foreach(Word word in word.translationCollection[targetLanguage].Values) {
				translationListBox.Items.Add(word);
			}
		}

		private void addTranslationBtn_Click(object sender, EventArgs e) {
			if (sourceListBox.SelectedItems.Count == 0) {
				return;
			}

			foreach (Word word in sourceListBox.SelectedItems) {
				if (translationListBox.Items.Contains(word)) {
					continue;
				}

				try {
					this.word.translationCollection[targetLanguage].Add(word.id, word);
				} catch(Exception) {
					this.word.translationCollection.Add(targetLanguage, new Dictionary<String, Word>());
					this.word.translationCollection[targetLanguage].Add(word.id, word);
				}

				translationListBox.Items.Add(word);
			}
		}

		private void removeTranslationBtn_Click(object sender, EventArgs e) {
			if (translationListBox.SelectedItems.Count == 0) {
				return;
			}
			
			List<Word> selected = new List<Word>();

			foreach (Word word in translationListBox.SelectedItems) {
				selected.Add(word);
			}

			translationListBox.ClearSelected();

			foreach (Word word in selected) {
				translationListBox.Items.Remove(word);
				this.word.translationCollection[targetLanguage].Remove(word.id);
			}
		}

		private void sourceSearchTextBox_TextChanged(object sender, EventArgs e) {
			String keyword;

			if((keyword = sourceSearchTextBox.Text).Length == 0) {
				renderSourceListBox();
				return;
			}

			sourceListBox.Items.Clear();

			foreach(Word word in dict.Values.Where(w => w.name.Contains(sourceSearchTextBox.Text))) {
				sourceListBox.Items.Add(word);
			}
		}

		private void translationSearchTextBox_TextChanged(object sender, EventArgs e) {
			String keyword;

			if((keyword = translationSearchTextBox.Text).Length == 0) {
				renderTranslationListBox();
				return;
			}

			translationListBox.Items.Clear();

			if (!word.translationCollection.ContainsKey(targetLanguage)) {
				return;
			}

			foreach(Word word in this.word.translationCollection[targetLanguage].Values.Where(w => w.name.Contains(keyword))) {
				translationListBox.Items.Add(word);
			}
		}
	}

}
