namespace ProiectAPD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butonLogin = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.parolaBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(137, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "       ";
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(139, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "       ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personal Autorizat";
            // 
            // butonLogin
            // 
            this.butonLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butonLogin.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonLogin.Location = new System.Drawing.Point(271, 268);
            this.butonLogin.Name = "butonLogin";
            this.butonLogin.Size = new System.Drawing.Size(270, 59);
            this.butonLogin.TabIndex = 6;
            this.butonLogin.Text = "Log In";
            this.butonLogin.UseVisualStyleBackColor = false;
            this.butonLogin.Click += new System.EventHandler(this.butonLogin_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(180, 187);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(431, 30);
            this.usernameBox.TabIndex = 8;
            // 
            // parolaBox
            // 
            this.parolaBox.Location = new System.Drawing.Point(180, 226);
            this.parolaBox.Name = "parolaBox";
            this.parolaBox.PasswordChar = '*';
            this.parolaBox.Size = new System.Drawing.Size(431, 30);
            this.parolaBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(820, 587);
            this.Controls.Add(this.parolaBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.butonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butonLogin;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox parolaBox;
    }
}

