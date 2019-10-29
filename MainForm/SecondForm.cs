using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class SecondForm : Form
    {
        tree tr;
        Node newnode = new Node();
        public SecondForm(tree t)
        {
            this.tr = t;
            InitializeComponent();
        }

        public SecondForm()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int insert;
                newnode = new Node(txtFName.Text, txtLName.Text, txtCNIC.Text, dateTimePicker1.Value, int.Parse(txtAge.Text), txtPOB.Text, txtAddress.Text, txtFather.Text, int.Parse(txtID.Text), txtSemester.Text, float.Parse(txtCGPA.Text));
                insert = tr.Insert(ref tr.root, newnode);
                
                if(insert == -1)
                {
                    MessageBox.Show("Student with a same ID already exsit");
                }
                else
                {
                    MessageBox.Show("Data Inserted");
                }

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter all values!");
            }
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Today;
            int y1 =  dateTimePicker1.Value.Year;
            int y2 = d1.Year;

            int age = y2 - y1;
            txtAge.Text = age.ToString();
        }
    }
}
