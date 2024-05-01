namespace formProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUserName = new Label();
            lbPassword = new Label();
            tbPassword = new TextBox();
            tbUserName = new TextBox();
            btnEnter = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(71, 57);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(78, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "UserNmae";
            lbUserName.Click += label1_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(71, 145);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(202, 142);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(241, 27);
            tbPassword.TabIndex = 2;
            tbPassword.TextChanged += textBox1_TextChanged;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(202, 54);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(241, 27);
            tbUserName.TabIndex = 3;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(202, 227);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(241, 34);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(349, 294);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 346);
            Controls.Add(btnRegister);
            Controls.Add(btnEnter);
            Controls.Add(tbUserName);
            Controls.Add(tbPassword);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserName;
        private Label lbPassword;
        private TextBox tbPassword;
        private TextBox tbUserName;
        private Button btnEnter;
        private Button btnRegister;
    }
}
