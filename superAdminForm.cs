using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formProject
{
    public partial class superAdminForm : Form
    {
        public superAdminForm()
        {
            InitializeComponent();
        }

        private void link_Click(object sender, EventArgs e)
        {
            string superAdminPath = @"D:\OOP\project\formProject\superAdmin\SuperAdminFilepath.txt";
            string topSuperAdmin = File.ReadAllText(superAdminPath);
            MessageBox.Show(topSuperAdmin);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
