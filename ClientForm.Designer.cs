namespace formProject
{
    partial class ClientForm
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
            linkClient = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkClient
            // 
            linkClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            linkClient.Location = new Point(129, 149);
            linkClient.Name = "linkClient";
            linkClient.Size = new Size(182, 39);
            linkClient.TabIndex = 0;
            linkClient.Text = "Link Client";
            linkClient.UseVisualStyleBackColor = true;
            linkClient.Click += linkClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 51);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 1;
            label1.Text = "Fayl yaratildi";
            label1.Click += label1_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 263);
            Controls.Add(label1);
            Controls.Add(linkClient);
            Name = "ClientForm";
            Text = "ClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button linkClient;
        private Label label1;
    }
}