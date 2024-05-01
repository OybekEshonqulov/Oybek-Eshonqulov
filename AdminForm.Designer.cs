namespace formProject
{
    partial class AdminForm
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
            linkAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 23);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 0;
            label1.Text = "Fayl yaratildi";
            // 
            // linkAdmin
            // 
            linkAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            linkAdmin.Location = new Point(110, 118);
            linkAdmin.Name = "linkAdmin";
            linkAdmin.Size = new Size(145, 41);
            linkAdmin.TabIndex = 1;
            linkAdmin.Text = "LinkAdmin";
            linkAdmin.UseVisualStyleBackColor = true;
            linkAdmin.Click += linkAdmin_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 267);
            Controls.Add(linkAdmin);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button linkAdmin;
    }
}