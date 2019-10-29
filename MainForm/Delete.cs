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
    public partial class Delete : Form
    {
        tree tre = new tree();
        public Delete(tree t)
        {
            this.tre = t;
            InitializeComponent();
        }
        public Delete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text.Equals(""))
            {
                MessageBox.Show("Please Enter ID!");
            }
            else
            {
                int data = int.Parse(txtDelete.Text);
                int delete = tre.Delete_data(ref tre.root, data);

                if (delete == -1)
                {
                    MessageBox.Show("No Data Deleted");
                }
                else
                {
                    MessageBox.Show("Data Deleted");
                }

                Close();
            }
        }
    }
}
