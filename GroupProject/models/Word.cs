using System;
using System.Collections.Generic;

namespace GroupProject.models {

	class Word {
		
		private String ID = "";

		private String Name = "";

		private String Definition = "";

		public String id {
			get { return ID; }

			set {
				if(value.Length == 0) {
					throw new Exception("Word id can not be empty");
				}

				ID = value;
			}
		}

		public String name {
			get { return Name; }

			set {
				if (value.Length == 0) {
					throw new Exception("Word name can not be empty");
				}

				Name = value;
			}
		}

		public WordType type { get; set; } = WordType.ADJECTIVE;
	
		public String definition {
			get { return Definition; }

			set {
				if(value.Length == 0) {
					throw new Exception("Word definition can not be empty");
				}

				Definition = value;
			}
		}

		public List<Word> translation = null;

		public String translationRef { get; set; }

		public Dictionary<Language, Dictionary<String, Word>> translationCollection { get; set; } = new Dictionary<Language, Dictionary<String, Word>>();

	}
}
