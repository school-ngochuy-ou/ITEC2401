using System.Windows.Forms;

namespace GroupProject.forms {

	public partial class Home: Form {

		public Home() {
			InitializeComponent();
		}

		private void vieEngBtn_Click(object sender, System.EventArgs e) {
			new VietnameseEnglishDictionary().Show();
			Hide();
		}

	}
}
