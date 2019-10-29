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
    public partial class Search : Form
    {
        tree tre = new tree();
        public Search(tree t)
        {
            this.tre = t;
            InitializeComponent();
        }
        public Search()
        {
            InitializeComponent();
           
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter ID!");
            }
            else
            {
                Node temp = new Node();
                int data = int.Parse(txtID.Text);
                temp = tre.Search(ref tre.root, data);

                if (temp == null)
                {
                    MessageBox.Show("No record found");
                    txtID.Text = "";
                }
                else
                {
                    lblID.Text = temp.id.ToString();
                    lblFName.Text = temp.firstName;
                    lblLName.Text = temp.lastName;
                    lblCNIC.Text = temp.cnic;
                    lblPOB.Text = temp.placeOFbirth;
                    lblFatherName.Text = temp.fatherName;
                    lblAddress.Text = temp.address;
                    lblDOB.Text = temp.dateOFbirth.ToString("d");
                    lblSemester.Text = temp.semester;
                    lblCGPA.Text = temp.cgpa.ToString();
                    lblAge.Text = temp.age.ToString();


                    pnlDetails.Show();
                    lnkClear.Show();
                }
            }
          
            
        }

        private void Search_Load(object sender, EventArgs e)
        {
            pnlDetails.Hide();
            lnkClear.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlDetails.Hide();
            lnkClear.Hide();
        }

        private void pnlDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
