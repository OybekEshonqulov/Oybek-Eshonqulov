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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void linkClient_Click(object sender, EventArgs e)
        {
            string clientPath = @"D:\OOP\project\formProject\Client\ClientFilepath.txt";
            string topClient = File.ReadAllText(clientPath);
            MessageBox.Show(topClient);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
