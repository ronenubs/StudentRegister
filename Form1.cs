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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumber.NumberOnly(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student s = new Student(
                    -1,
                    txtFirstname.Text,
                    txtMiddlename.Text,
                    txtLastname.Text,
                    Convert.ToInt32(txtAge.Text),
                    txtAddress.Text
                );
            string response = MyRestClient.InsertStudent(s);

            if(response.Equals("success"))
            {
                MessageBox.Show("Student is sucessfully added.");
            }
           
            StudentInfo info = new StudentInfo();
            info.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtFirstname.ResetText();
            txtMiddlename.ResetText();
            txtLastname.ResetText();
            txtAge.ResetText();
            txtAddress.ResetText();
            txtFirstname.Focus();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
