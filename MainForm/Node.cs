using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Node //Class of Node 
    {
        public string firstName;
        public string lastName;
        public string cnic;
        public DateTime dateOFbirth;
        public int age;
        public string placeOFbirth;
        public string address;
        public string fatherName;
        public int id;
        public string semester;
        public float cgpa;
        public Node Left;
        public Node Right;
        public Node()   //Default Constructor
        {
            Left = null;
            Right = null;
        }

        public Node(string firstName, string lastName, string cnic, DateTime dateOFbirth, int age, string placeOFbirth, string address, string fatherName, int id, string semester, float cgpa) //Perametrized Constructor
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cnic = cnic;
            this.dateOFbirth = dateOFbirth;
            this.age = age;
            this.placeOFbirth = placeOFbirth;
            this.address = address;
            this.fatherName = fatherName;
            this.id = id;
            this.semester = semester;
            this.cgpa = cgpa;

        }
    }
}
