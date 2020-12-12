using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace GroupProject.models {

	class Storage {
		
		private String storageLocation = $@"{Directory.GetCurrentDirectory()}\storage\";
		
		private Dictionary<Language, Metamodel> metamodels = new Dictionary<Language, Metamodel>();

		private Dictionary<Language, Dictionary<String, Word>> collections = new Dictionary<Language, Dictionary<string, Word>>();

		public Storage() {
			init();
		}

		private void init() {
			if (!Directory.Exists(storageLocation)) {
				Directory.CreateDirectory(storageLocation);
			}

			Metamodel model = new Metamodel();

			model.storageFilename = "vie.txt";
			model.lang = Language.Vietnamese;
			metamodels.Add(Language.Vietnamese, model);

			model = new Metamodel();
			model.storageFilename = "en.txt";
			model.lang = Language.English;
			metamodels.Add(Language.English, model);

			foreach (Metamodel meta in metamodels.Values) {
				if (!File.Exists($"{storageLocation}{meta.storageFilename}")) {
					StreamWriter writer = File.CreateText($"{storageLocation}{meta.storageFilename}");

					writer.WriteLine("0");
					writer.Flush();
					writer.Close();
				}

				collections.Add(meta.lang, read(meta.lang));
			}

			mapTranslations();
		}

		private Dictionary<String, Word> read(Language lang) {
			Metamodel metamodel = metamodels[lang];
			const Int32 BufferSize = 128;
			String path = $"{storageLocation}{metamodel.storageFilename}";
			FileStream stream = File.OpenRead(path);
			StreamReader reader = new StreamReader(stream, Encoding.UTF8, true, BufferSize);
			String line = reader.ReadLine();

			if (line == null) {
				throw new Exception($"Error reading file {path}. No identifier found.");
			}

			metamodel.nextId = long.Parse(line);
			Console.WriteLine($"Reading storage {metamodel.storageFilename} with {metamodel.nextId} is the next identifier.");

			Dictionary<String, Word> collection = new Dictionary<String, Word>();
			Word word;

			while ((line = reader.ReadLine()) != null) {
				word = readLineIntoWord(line);	
				collection.Add(word.id, word);
			}

			reader.Close();

			return collection;
		}

		private void mapTranslations() {
			String[] translationEntries;
			String[] entryParts;
			Language targetedLang;
			Word translation;

			foreach (Language lang in Enum.GetValues(typeof(Language))) {
				foreach (Word word in collections[lang].Values) {
					if (word.translationRef.Length == 0) {
						continue;
					}

					translationEntries = word.translationRef.Split('|');

					foreach (String entry in translationEntries) {
						entryParts = entry.Split('@');

						if (entryParts.Length != 2) {
							continue;
						}

						if (!Enum.IsDefined(typeof(Language), entryParts[0])) {
							continue;
						}

						targetedLang = (Language) Enum.Parse(typeof(Language), entryParts[0]);
						translation = collections[targetedLang][entryParts[1]];

						if(translation == null) {
							throw new Exception($"Word with identifier {entryParts[1]} not found in language {targetedLang}");
						}

						if (!word.translationCollection.ContainsKey(targetedLang)) {
							word.translationCollection.Add(targetedLang, new Dictionary<String, Word>());
						}

						word.translationCollection[targetedLang].Add(translation.id, translation);
					}
				}
			}
		}

		private Word readLineIntoWord(String line) {
			Word word = new Word();
			String[] parts = line.Split(',');
			
			word.id = parts[0].Split('\'')[1];
			word.name = parts[1].Split('\'')[1];
			word.definition = parts[2].Split('\'')[1];

			WordType type;

			Enum.TryParse(parts[3].Split('\'')[1], out type);
			word.type = type;
			word.translationRef = parts[4].Substring(1, parts[4].Length - 2);

			return word;
		}

		public Dictionary<String, Word> getCollection(Language lang) {

			return collections[lang];
		}

		public void addWord(Language lang, Word word) {
			Metamodel meta = metamodels[lang];
			long currentId = meta.nextId;

			word.id = meta.nextId++.ToString();
			
			String path = $"{storageLocation}{meta.storageFilename}";
			String content = meta.nextId.ToString() + File.ReadAllText(path).Substring(currentId.ToString().Length);
			StreamWriter writer = File.CreateText(path);

			writer.Write($"{content}\n'{word.id}','{word.name}','{word.definition}',E'{word.type}',[]");
			writer.Flush();
			writer.Close();
			collections[lang].Add(word.id, word);
		}

		public void editWord(Language lang, Word word) {
			if (word.id == null || word.id.Length == 0) {
				throw new Exception("Identifier not found.");
			}

			Metamodel meta = metamodels[lang];
			String path = $"{storageLocation}{meta.storageFilename}";
			String[] lines = File.ReadAllLines(path);
			long length = lines.Length;
			String line;

			for (int i = 1; i < length; i++) {
				line = lines[i];

				if (line.Split(',')[0].Split('\'')[1] == word.id) {
					lines[i] = $"'{word.id}','{word.name}','{word.definition}',E'{word.type}',[]";
					break;
				}
			}

			String content = String.Join("\n", lines);
			StreamWriter writer = File.CreateText(path);

			writer.Write(content);
			writer.Flush();
			writer.Close();
			collections[lang][word.id] = word;
		}

		public void deleteWord(Language lang, Word word) {
			if(word.id == null || word.id.Length == 0) {
				throw new Exception("Identifier not found.");
			}

			Metamodel meta = metamodels[lang];
			String path = $"{storageLocation}{meta.storageFilename}";
			String[] lines = File.ReadAllLines(path);
			long length = lines.Length;

			for (int i = 1; i < length; i++) {
				if (lines[i].Split(',')[0].Split('\'')[1] == word.id) {
					for (int j = i; j < length - 1; j++) {
						lines[j] = lines[j + 1];
					}

					break;
				}
			}

			String[] newLines = new String[lines.Length - 1];

			Array.Copy(lines, newLines, lines.Length - 1);

			String content = String.Join("\n", newLines);
			StreamWriter writer = File.CreateText(path);

			writer.Write(content);
			writer.Flush();
			writer.Close();
			collections[lang].Remove(word.id);
		}

	}

	class Metamodel {		

		public String storageFilename { get; set; }

		public Language lang { get; set; }

		public long nextId { get; set; }

	}

}
