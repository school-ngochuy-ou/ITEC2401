using System.Windows.Forms;

namespace GroupProject.forms {

	public partial class VietnameseEnglishDictionary : Form {

		public VietnameseEnglishDictionary() {
			InitializeComponent();
		}

		private void collectionToolStripMenuItem_Click(object sender, System.EventArgs e) {
			new WordCollection().Show();
		}
	}

}
