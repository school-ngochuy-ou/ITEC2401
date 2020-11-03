using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter4 {
    public partial class MyPhotos : Form {

        private const String SINGULAR = "SINGULAR";

        private const String PLURAL = "PLURAL";

        private List<KittenPhoto> kittenPhotos = new List<KittenPhoto>();

        private KittenPhoto currentPhoto;

        public MyPhotos() {
            InitializeComponent();
            toggleContext(SINGULAR);
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            KittenPhoto kittenPhoto = new KittenPhoto();

            kittenPhoto.setContainer(this);
            kittenPhoto.Show();
            kittenPhotos.Add(kittenPhoto);

            if (kittenPhotos.Count == 1) {
                toggleContext(PLURAL);
            }
        }

        private void clearAllKittenPhotos(object sender, EventArgs e) {
            foreach (KittenPhoto photo in kittenPhotos) {
                photo.Close();
            }

            kittenPhotos.Clear();
            toggleContext(SINGULAR);
        }

        private void formClose(object sender, EventArgs e) {
            this.Close();
        }

        private void openImageDialog(object sender, EventArgs e) {
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                currentPhoto.setImage(fileDialog.FileName);
            }
        }

        private void reloadKittenPhoto(object sender, EventArgs e) {
            currentPhoto.setImage(Properties.Resources.kitten);
        }

        public void clearImage(object sender, EventArgs e) {
            currentPhoto.clearImage();
        }

        public void saveImage(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                currentPhoto.saveImage(saveFileDialog.FileName);
            }
        }

        public void setTarget(KittenPhoto photo) {
            currentPhoto = photo;
        }

        private void toggleContext(String mode) {
            ToolStripMenuItem newItem = new ToolStripMenuItem("New");

            newItem.Click += new EventHandler(newToolStripMenuItem_Click);

            ToolStripSeparator dividerOne = new ToolStripSeparator();
            ToolStripMenuItem closeAllItem = new ToolStripMenuItem("Close All");

            closeAllItem.Click += new EventHandler(clearAllKittenPhotos);

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit");

            exitItem.Click += new EventHandler(formClose);

            switch(mode) {
                case SINGULAR: {
                        fileToolStripMenuItem.DropDownItems.Clear();
                        fileToolStripMenuItem.DropDownItems.Add(newItem);
                        fileToolStripMenuItem.DropDownItems.Add(dividerOne);
                        fileToolStripMenuItem.DropDownItems.Add(closeAllItem);
                        fileToolStripMenuItem.DropDownItems.Add(exitItem);

                        break;
                };
                case PLURAL: {
                        fileToolStripMenuItem.DropDownItems.Clear();
                        fileToolStripMenuItem.DropDownItems.Add(newItem);
                        fileToolStripMenuItem.DropDownItems.Add(dividerOne);

                        ToolStripMenuItem loadItem = new ToolStripMenuItem("Load");

                        loadItem.Click += new EventHandler(reloadKittenPhoto);

                        ToolStripMenuItem openItem = new ToolStripMenuItem("Open");

                        openItem.Click += new EventHandler(openImageDialog);

                        ToolStripMenuItem clearItem = new ToolStripMenuItem("Clear");

                        clearItem.Click += new EventHandler(clearImage);

                        ToolStripMenuItem saveItem = new ToolStripMenuItem("Save");

                        saveItem.Click += new EventHandler(saveImage);

                        ToolStripSeparator dividerTwo = new ToolStripSeparator();

                        fileToolStripMenuItem.DropDownItems.Add(loadItem);
                        fileToolStripMenuItem.DropDownItems.Add(openItem);
                        fileToolStripMenuItem.DropDownItems.Add(clearItem);
                        fileToolStripMenuItem.DropDownItems.Add(saveItem);
                        fileToolStripMenuItem.DropDownItems.Add(dividerTwo);
                        fileToolStripMenuItem.DropDownItems.Add(closeAllItem);
                        fileToolStripMenuItem.DropDownItems.Add(exitItem);

                        break;
                }
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
