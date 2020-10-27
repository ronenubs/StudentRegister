using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegister
{
    public partial class StudentInfo : Form
    {

        private Student student;

        public StudentInfo()
        {
            InitializeComponent();
        }

        public StudentInfo(Student student) : this()
        {
            this.student = student;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            string result = MyRestClient.GetAllStudents();
            //MessageBox.Show(result);
            List<Student> student = JsonConvert.DeserializeObject<List<Student>>(result);
            foreach (var s in student)
            {
                dgStudents.Rows.Add(
                    s.StudentID,
                    s.Firstname,
                    s.Middlename,
                    s.Lastname,
                    s.Age,
                    s.Address
                    );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MyRestClient.DeleteStudent(Convert.ToInt32(dgStudents.CurrentRow.Cells[0].Value));
            dgStudents.Rows.Clear();
            LoadStudents();
        }
    }
}
