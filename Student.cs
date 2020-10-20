using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister
{
    public class Student
    {
        private int studentID;
        private string firstname, middlename, lastname;
        private int age;
        private string address;

        public Student(int studentID, string firstname, string middlename, string lastname, int age, string address)
        {
            this.studentID = studentID;
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.age = age;
            this.address = address;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Middlename { get => middlename; set => middlename = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        
    }
}
