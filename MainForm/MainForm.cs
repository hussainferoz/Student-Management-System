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
    public partial class MainForm : Form
    {
        tree tre = new tree(); //Object of tree
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }


        private void btnDelete_Click(object sender, EventArgs e) //Delete Button
        {
            Delete d = new Delete(tre);
            d.Show(); //Opens Delete Form
        }

        private void btnInsert_Click(object sender, EventArgs e) //Insert Button
        {
            SecondForm s = new SecondForm(tre);
            s.Show(); //Opens Insert Form
        }

        private void btnExit_Click(object sender, EventArgs e)//Exit Button
        {
            Close(); //Exists the program
        }

        private void btnSearch_Click(object sender, EventArgs e) //Search Button
        {
            Search s = new Search(tre);
            s.Show(); //Opens Search Form
        }

        private void btnDisplay_Click(object sender, EventArgs e) //Display Button
        {
            frmDisplay d = new frmDisplay(tre);
            d.Show(); //Opens Display Form
        }
    }
}
