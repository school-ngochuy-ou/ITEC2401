using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceProgramming.Chapter6 {
    public partial class StudentManagement : Form {

        private Student model = new Student();

        private List<Student> list = new List<Student>(new Student[]{ new Student("1101", "Tran", "Huy"), new Student("1102", "Dang", "Anh"), new Student("1103", "Zych", "Fuct") });

        public StudentManagement() {
            InitializeComponent();

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();

            idColumn.DataPropertyName = "id";
            idColumn.HeaderText = "ID";
            idColumn.Name = "ID";

            DataGridViewColumn firstNameColumn = new DataGridViewTextBoxColumn();

            firstNameColumn.DataPropertyName = "firstName";
            firstNameColumn.HeaderText = "Firstname";
            firstNameColumn.Name = "Firstname";

            DataGridViewColumn lastNameColumn = new DataGridViewTextBoxColumn();

            lastNameColumn.DataPropertyName = "lastName";
            lastNameColumn.HeaderText = "Lastname";
            lastNameColumn.Name = "Lastname";
            
            listView.Columns.Add(idColumn);
            listView.Columns.Add(firstNameColumn);
            listView.Columns.Add(lastNameColumn);
            renderStudentList();
        }

        private void renderStudentList() {
            BindingList<Student> source = new BindingList<Student>();

            foreach (Student s in list) {
                source.Add(s);
            }

            listView.DataSource = source;
        }

        private void renderModel() {
            idInput.Text = model.id;
            firstNameInput.Text = model.firstName;
            lastNameInput.Text = model.lastName;
        }

        private void idInput_TextChanged(object sender, EventArgs e) {
            model.id = idInput.Text;
        }

        private void firstNameInput_TextChanged(object sender, EventArgs e) {
            model.firstName = firstNameInput.Text;
        }

        private void lastNameInput_TextChanged(object sender, EventArgs e) {
            model.lastName = lastNameInput.Text;
        }

        private void addBtn_Click(object sender, EventArgs e) {
            if (model.id.Length == 0 || model.firstName.Length == 0 || model.lastName.Length == 0) {
                return;
            }

            foreach (Student s in list) {
                if (s.id == model.id) {
                    messageLabel.Text = "Duplicate ID";
                    return;
                }
            }

            messageLabel.Text = "";
            list.Add(new Student(model));
            model = new Student();
            renderStudentList();
            renderModel();
            return;
        }

        private void keywordInput_TextChanged(object sender, EventArgs e) {
            BindingList<Student> elements = new BindingList<Student>();
            String kw = keywordInput.Text.ToLower();

            foreach (Student s in list) {
                if (s.id.Contains(kw) || s.lastName.ToLower().Contains(kw)) {
                    elements.Add(s);
                }
            }

            if (elements.Count != 0) {
                listView.DataSource = elements;
                return;
            }

            listView.DataSource = list;
            return;
        }

        private void sortBtn_Click(object sender, EventArgs e) {
            List<Student> copy = ((BindingList<Student>) listView.DataSource).OrderBy(x => x.lastName).ToList();
            BindingList<Student> elements = new BindingList<Student>();

            foreach (Student s in copy) {
                elements.Add(s);
            }

            listView.DataSource = elements;
        }

        private void StudentManagement_FormClosed(object sender, FormClosedEventArgs e) {
            Program.menuForm.Show();
        }
    }

    class Student {

        public String id { get; set; }

        public String firstName { get; set; }

        public String lastName { get; set; }

        public Student() {
            this.id = "";
            this.firstName = "";
            this.lastName = "";
        }

        public Student(Student stud) {
            this.id = stud.id;
            this.firstName = stud.firstName;
            this.lastName = stud.lastName;
        }

        public Student(String id, String firstName, String lastName) {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }

}
