using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter4 {
    public partial class ComboListBox : Form {

        private LeftPanel leftPanel = new LeftPanel(new List<String>(new String[] { "element1", "element2", "element3" }));

        private RightPanel rightPanel = new RightPanel(new List<String>(new String[] { "element1", "element2", "element3" }));

        public ComboListBox() {
            InitializeComponent();
            renderColorComboBox();
            renderLeftListBox();
            renderRightListBox();
        }

        public void renderColorComboBox() {
            foreach (KnownColor color in rightPanel.colors) {
                colorComboBox.Items.Add(color.ToString());
            }

            colorComboBox.SelectedItem = rightPanel.selectedColor.ToString();
            rightListBox.BackColor = rightPanel.selectedColor;
        }

        private void renderLeftListBox() {
            leftListBox.Items.Clear();

            foreach (String ele in leftPanel.elements) {
                leftListBox.Items.Add(ele);
            }
        }

        private void renderRightListBox() {
            rightListBox.Items.Clear();

            foreach (String ele in rightPanel.elements) {
                rightListBox.Items.Add(ele);
            }
        }

        private void addToLeftListBox(String ele) {
            leftPanel.elements.Add(ele);
            leftListBox.Items.Add(ele);
        }

        private void removeFromLeftListBox(String ele) {
            leftPanel.elements.Remove(ele);
            leftListBox.Items.Remove(ele);
        }

        private void addToRightListBox(String ele) {
            rightPanel.elements.Add(ele);
            rightListBox.Items.Add(ele);
        }

        private void removeFromRightListBox(String ele) {
            rightPanel.elements.Remove(ele);
            rightListBox.Items.Remove(ele);
        }

        private void stringInput_TextChanged(object sender, EventArgs e) {
            leftPanel.inputString = stringInput.Text;
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void insertBtn_Click(object sender, EventArgs e) {
            String val = stringInput.Text;

            if (val.Length == 0) {
                return;
            }

            addToLeftListBox(stringInput.Text);
            stringInput.Text = "";
        }

        private void toLeftBtn_Click(object sender, EventArgs e) {
            ListBox.SelectedObjectCollection selected = rightListBox.SelectedItems;

            IEnumerator iterator = selected.GetEnumerator();
            List<String> vals = new List<String>();

            while (iterator.MoveNext()) {
                vals.Add(iterator.Current.ToString());
            }

            foreach (String val in vals) {
                addToLeftListBox(val);
                removeFromRightListBox(val);
            }
        }

        private void toRightBtn_Click(object sender, EventArgs e) {
            ListBox.SelectedObjectCollection selected = leftListBox.SelectedItems;

            IEnumerator iterator = selected.GetEnumerator();
            List<String> vals = new List<String>();

            while (iterator.MoveNext()) {
                vals.Add(iterator.Current.ToString());
            }

            foreach (String val in vals) {
                addToRightListBox(val);
                removeFromLeftListBox(val);
            }
        }

        private void clearAllBtn_Click(object sender, EventArgs e) {
            leftPanel.elements = new List<String>();
            rightPanel.elements = new List<String>();
            renderLeftListBox();
            renderRightListBox();
        }

        private void removeBtn_Click(object sender, EventArgs e) {
            IEnumerator enumerator = leftListBox.SelectedItems.GetEnumerator();
            List<String> elements = new List<String>();
            
            while (enumerator.MoveNext()) {
                elements.Add(enumerator.Current.ToString());
            }

            foreach (String s in elements) {
                removeFromLeftListBox(s);
            }

            elements.Clear();
            enumerator = rightListBox.SelectedItems.GetEnumerator();

            while (enumerator.MoveNext()) {
                elements.Add(enumerator.Current.ToString());
            }

            foreach (String s in elements) {
                removeFromRightListBox(s);
            }
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox box = (ComboBox) sender;

            rightPanel.selectedColor = Color.FromName(box.SelectedItem.ToString());
            rightListBox.BackColor = rightPanel.selectedColor;
        }
    }

    class CustomPanel {

        public List<String> elements { get; set; }

        public CustomPanel(List<String> elements) {
            this.elements = elements;
        }

    }

    class LeftPanel: CustomPanel {

        public String inputString { get; set; }

        public LeftPanel(List<String> elements) : base(elements) {
            
        }

    }

    class RightPanel: CustomPanel {

        public KnownColor[] colors;

        public Color selectedColor;

        public RightPanel(List<String> elements) : base(elements) {
            colors = (KnownColor[]) Enum.GetValues(typeof(KnownColor));
            selectedColor = Color.FromKnownColor(colors[0]);
        }

    }

}
