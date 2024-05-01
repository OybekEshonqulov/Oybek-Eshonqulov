namespace formProject
{
    partial class superAdminForm
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
            link = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 59);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 0;
            label1.Text = "File yaratildi";
            label1.Click += label1_Click;
            // 
            // link
            // 
            link.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            link.Location = new Point(137, 166);
            link.Name = "link";
            link.Size = new Size(154, 45);
            link.TabIndex = 1;
            link.Text = "Link Super Admin";
            link.UseVisualStyleBackColor = true;
            link.Click += link_Click;
            // 
            // superAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 301);
            Controls.Add(link);
            Controls.Add(label1);
            Name = "superAdminForm";
            Text = "superAdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button link;
    }
}