using System.Text.Json;

namespace formProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
         
            string UserListPath = @"D:\OOP\project\formProject\UserList.txt";
            List<users> users = new List<users>();
            string[] UserListMassiv=File.ReadAllLines(UserListPath);
            for(int i = 0; i < UserListMassiv.Length; i++)
            {
                string[] userListLine = UserListMassiv[i].Split(",");
                users.Add(new users() { UserType = userListLine[0], FIO = userListLine[1], UserName = userListLine[2], Password = userListLine[3] });
            }
            int sanoq = 0;
            foreach (users item in users)
            {
                if(item.UserName==tbUserName.Text && item.Password == tbPassword.Text)
                {
                    sanoq++;

                    if(item.UserType==userType.SuperAdmin.ToString() )
                    {
                    //D:\OOP\project\formProject
                        string pathSuperAdmin = @"D:\OOP\project\formProject\superAdmin";
                        string pathSuperAdminFile = Path.Combine(pathSuperAdmin, "SuperAdminFilepath.txt");
                        Directory.CreateDirectory(pathSuperAdmin);
                        StreamWriter streamWriter=File.CreateText(pathSuperAdminFile);
                        foreach(users users1 in users)
                        {
                            if (users1.UserType == userType.SuperAdmin.ToString())
                                continue;
                            streamWriter.WriteLine(users1.FIO+users1.UserName+users1.UserType+users1.Password);
                        }
                        streamWriter.Close();
                        this.Hide();
                        superAdminForm superAdminForm = new superAdminForm();
                        superAdminForm.Show();
                    }
                    else if(item.UserType ==userType.Admin.ToString())
                    {
                        string pathAdmin = @"D:\OOP\project\formProject\Admin";
                        string pathAdminFile = Path.Combine(pathAdmin, "AdminFilepath.txt");
                        Directory.CreateDirectory(pathAdmin);
                        StreamWriter streamWriter = new StreamWriter(pathAdminFile);
                        foreach (users users1 in users)
                        {
                            if (users1.UserType == userType.Admin.ToString() || users1.UserType==userType.SuperAdmin.ToString())
                                continue;
                            streamWriter.WriteLine(users1.FIO + users1.UserName + users1.UserType + users1.Password);
                        }
                        streamWriter.Close();
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        users users1=new users();
                        foreach(users users2 in users)
                        {
                            users1.FIO = users2.FIO;
                            users1.UserName = users2.UserName;
                            users1.Password = users2.Password;
                            users1.UserType = users2.UserType;
                        }
                        string jsonString = JsonSerializer.Serialize(users1);
                        string ClientFolderPath = @"D:\OOP\project\formProject\Client";
                        string ClientFilePath = Path.Combine(ClientFolderPath, "ClientFilePath.txt");
                        Directory.CreateDirectory(ClientFolderPath);
                        StreamWriter streamWriter=new StreamWriter(ClientFilePath);
                        streamWriter.WriteLine(jsonString); 
                        streamWriter.Close();
                        this.Hide();
                        ClientForm clientForm = new ClientForm();
                        clientForm.Show();

                    }
                }
              
            }
            if (sanoq == 0)
            {
                MessageBox.Show("mirjahon xuyyet qivotti jallab");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
    enum userType
    {
        SuperAdmin,
        Admin,
        Client
    }
}
