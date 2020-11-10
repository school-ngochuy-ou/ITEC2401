using System;
using System.IO;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter7 {
    public partial class ListViewDemo : Form {

        private String selectedPath = "";

        public ListViewDemo() {
            InitializeComponent();
            renderDrives();
            renderListView();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void renderDrives() {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();

            foreach (DriveInfo info in driveInfo) {
                if (!info.IsReady) {
                    continue;
                }

                harddriveComboBox.Items.Add(info.Name);
            }

            var path = harddriveComboBox.Items[0];

            harddriveComboBox.SelectedItem = path;
            selectedPath = path.ToString();
            directoryLabel.Text = path.ToString();
        }

        private void renderListView() {
            DirectoryInfo rootInfo = new DirectoryInfo(selectedPath);
            String[] dirs;

            try {
                dirs = Directory.GetDirectories(selectedPath);
            } catch (Exception) {
                MessageBox.Show($"{selectedPath} is not avaiable.", "Error", MessageBoxButtons.OK);

                String[] parts = selectedPath.Split('\\');
                String newDir = "";

                for (int i = 0; i < parts.Length - 1; i+=2) {
                    newDir += $"{parts[i]}\\";
                }

                selectedPath = newDir;
                directoryLabel.Text = newDir;
                return;
            }

            DirectoryInfo info = null;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            FileInfo[] fileInfos = rootInfo.GetFiles();

            listView.Items.Clear();

            foreach (String dir in dirs) {
                info = new DirectoryInfo(dir);
                item = new ListViewItem(info.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[] {
                    new ListViewItem.ListViewSubItem(item, ""),
                    new ListViewItem.ListViewSubItem(item, info.LastAccessTime.ToString())
                };
                item.SubItems.AddRange(subItems);
                listView.Items.Add(item);
            }

            foreach (FileInfo fileInfo in fileInfos) {
                item = new ListViewItem(fileInfo.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[] {
                    new ListViewItem.ListViewSubItem(item, fileInfo.Length.ToString()),
                    new ListViewItem.ListViewSubItem(item, fileInfo.LastAccessTime.ToString())
                };
                item.SubItems.AddRange(subItems);
                listView.Items.Add(item);
            }
        }

        private void harddriveComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            var path = harddriveComboBox.SelectedItem;

            selectedPath = path.ToString();
            directoryLabel.Text = path.ToString();
            renderListView();
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (listView.SelectedItems.Count == 0) {
                return;
            }

            var selectedItem = listView.SelectedItems[0];
            String path = $"{directoryLabel.Text}\\{selectedItem.SubItems[0].Text}";
            FileAttributes attr;

            try {
                attr = File.GetAttributes(path);
            } catch (Exception) {
                MessageBox.Show($"Can not open {path}.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (attr.HasFlag(FileAttributes.Directory)) {
                directoryLabel.Text = path;
                selectedPath = path;
                renderListView();

                return;
            }

            try {
                System.Diagnostics.Process.Start(path);
            } catch (Exception) {
                MessageBox.Show($"Can not open file {selectedPath}.", "Error", MessageBoxButtons.OK);
            }

            return;
        }

        private void largeIconRadioBtn_CheckedChanged(object sender, EventArgs e) {
            listView.View = View.LargeIcon;
        }

        private void smallIconRadioBtn_CheckedChanged(object sender, EventArgs e) {
            listView.View = View.SmallIcon;
        }

        private void listRadioBtn_CheckedChanged(object sender, EventArgs e) {
            listView.View = View.List;
        }

        private void detailsRadioBtn_CheckedChanged(object sender, EventArgs e) {
            listView.View = View.Details;
        }

        private void titleRadioBtn_CheckedChanged(object sender, EventArgs e) {
            listView.View = View.Tile;
        }
    }
}
