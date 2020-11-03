using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter4 {
    public partial class KittenPhoto : Form {

        private MyPhotos container;

        public KittenPhoto() {
            InitializeComponent();
        }

        public void setContainer(MyPhotos container) {
            this.container = container;
        }

        public void setImage(String path) {
            pictureBox.Image = Image.FromFile(path);
        }

        public void setImage(Bitmap bitmap) {
            pictureBox.Image = bitmap;
        }

        public void clearImage() {
            pictureBox.Image = null;
        }

        public void saveImage(String filename) {
            pictureBox.Image.Save(filename);
        }

        private void KittenPhoto_Activated(object sender, EventArgs e) {
            container.setTarget(this);
        }
    }
}
