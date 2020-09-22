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
            lblFullname.Text =
                student.Firstname + " " +
                student.Middlename + " " +
                student.Lastname;

            lblAge.Text = student.Age.ToString();
            lblAddress.Text = student.Address;
        }
    }
}
