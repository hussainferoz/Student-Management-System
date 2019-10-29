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
    public partial class frmDisplay : Form
    {
        tree tr = new tree();
        DataTable table = new DataTable();
        public frmDisplay(tree t)
        {
            this.tr = t;
            InitializeComponent();
        }
        public frmDisplay()
        {
            InitializeComponent(); 
        }

        public void Inorder(ref Node root)
        {
            if (root == null)
            {
               //MessageBox.Show("No record found");
                return;
            }

            Inorder(ref root.Left);
            table.Rows.Add(root.id, root.firstName, root.lastName, root.fatherName, root.age, root.dateOFbirth.ToString("d"), root.cnic, root.placeOFbirth, root.semester, root.cgpa);
            Inorder(ref root.Right);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Father Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Date Of Birth", typeof(string));
            table.Columns.Add("CNIC", typeof(string));
            table.Columns.Add("Place Of Birth", typeof(string));
            table.Columns.Add("Semester", typeof(string));
            table.Columns.Add("CGPA", typeof(float));
            
            Inorder(ref tr.root);

            dataGridView1.DataSource = table;           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            table = null;

            Close();
        }
    }
}
