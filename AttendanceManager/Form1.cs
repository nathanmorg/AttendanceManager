using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AttendanceManager
{
    public partial class Form1 : Form
    {
        DatabaseHandler dataHandler = new DatabaseHandler();
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = dataHandler.getStudentsFromDatabase();

            studentBindingSource.DataSource = students;
;       }

        private void btnNext_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveNext();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            studentBindingSource.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveLast();
        }

        private void btnMarkAbsent_Click(object sender, EventArgs e)
        {
            //Get the current student
            Student currentStudent = (Student)studentBindingSource.Current;

            //Update the text with a new absence
            numberAbsencesTextBox.Text = (currentStudent.numberAbsences + 1).ToString();

            //Update the database by selecting the students id and adding 1 to the current number of absences
            dataHandler.markAbsent(currentStudent.id, currentStudent.numberAbsences);

            //Update the studentBindingSource with the new database
            studentBindingSource.EndEdit();
        }
    }
}
