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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void linkAdmin_Click(object sender, EventArgs e)
        {
            string AdminPath = @"D:\OOP\project\formProject\Admin\AdminFilepath.txt";
            string topAdmin = File.ReadAllText(AdminPath);
            MessageBox.Show(topAdmin);
        }
    }
}
