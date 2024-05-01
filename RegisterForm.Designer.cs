namespace formProject
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbFIO = new TextBox();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            btRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 60);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "FIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 127);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 195);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tbFIO
            // 
            tbFIO.Location = new Point(180, 60);
            tbFIO.Name = "tbFIO";
            tbFIO.Size = new Size(247, 27);
            tbFIO.TabIndex = 3;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(180, 127);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(247, 27);
            tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(180, 188);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(247, 27);
            tbPassword.TabIndex = 5;
            // 
            // btRegister
            // 
            btRegister.Location = new Point(180, 259);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(247, 29);
            btRegister.TabIndex = 6;
            btRegister.Text = "Tasdiqlash";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 360);
            Controls.Add(btRegister);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(tbFIO);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbFIO;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Button btRegister;
    }
}