using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
