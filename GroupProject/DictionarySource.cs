using System;
using System.Collections.Generic;
using GroupProject.models;

namespace GroupProject {

	class DictionarySource {

		private Dictionary<Language, Dictionary<String, Word>> dictionaries = new Dictionary<Language, Dictionary<String, Word>>();

		private Dictionary<String, Word> vieDictionary = new Dictionary<String, Word>();

		private Dictionary<String, Word> enDictionary = new Dictionary<String, Word>();

		public DictionarySource() {
			Word w = new Word();

			w.name = "hello";
			w.id = "1";
			w.definition = "definition";
			w.type = WordType.VERB;
			w.examples.Add("dictionaries.Add(Language.English, enDictionary);");
			w.examples.Add("dictionaries.Add(Language.Vietnamese, vieDictionary);");
			enDictionary.Add("1", w);

			w = new Word();
			w.id = "2";
			w.name = "greeting";
			w.definition = "greeting definition";
			w.type = WordType.NOUN;
			w.examples.Add("dictionaries.Add(Language.English, enDictionary);");
			w.examples.Add("dictionaries.Add(Language.Vietnamese, vieDictionary);");
			w.examples.Add("dictionaries.Add(Language.Vietnamese, vieDictionary);");
			enDictionary.Add("2", w);

			w = new Word();
			w.name = "chào";
			w.id = "1";
			w.definition = "Chào hỏi";
			w.type = WordType.VERB;
			w.examples.Add("dictionaries.Add(Language.English, enDictionary);");
			w.examples.Add("dictionaries.Add(Language.Vietnamese, vieDictionary);");
			w.examples.Add("dictionaries.Add(Language.Vietnamese, vieDictionary);");
			vieDictionary.Add("1", w);

			w = new Word();
			w.id = "2";
			w.name = "lời chào";
			w.definition = "Lời chào hỏi";
			w.type = WordType.NOUN;
			w.examples.Add("dictionaries.Add(Language.English, enDictionary);");
			w.examples.Add("dictionaries.Add(Language.Vietnamese, vieDictionary);");
			vieDictionary.Add("2", w);

			dictionaries.Add(Language.Vietnamese, vieDictionary);
			dictionaries.Add(Language.English, enDictionary);
		}

		public Dictionary<String, Word> getDictionary(Language language) {
			return dictionaries[language];
		}

		public void addWord(Language language, Word word) {
			word.id = Guid.NewGuid().ToString();
			dictionaries[language].Add(word.id, word);
		}

		public void editWord(Language language, Word word) {
			dictionaries[language][word.id] = word;
		}

		public void deleteWord(Language language, Word word) {
			dictionaries[language].Remove(word.id);
		}

	}

}
