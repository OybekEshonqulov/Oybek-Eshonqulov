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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
           
            string path = @"D:\OOP\project\formProject\UserList.txt";
            if (tbFIO.Text.Length > 0 && tbUserName.Text.Length>0 && tbPassword.Text.Length>0)
            {
                   File.AppendAllText(path,"\n"+userType.Client+","+tbFIO.Text+","+tbUserName.Text+","+tbPassword.Text);
                MessageBox.Show("muvaffaqqiyatli ruyhatdan utdingiz");
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
                
            }
            else
            {
                MessageBox.Show("bo'sh qiymat kiritdingiz qaytadan kiriting");
            }
        }
    }
}
