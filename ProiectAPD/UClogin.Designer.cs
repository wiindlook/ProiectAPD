
namespace ProiectAPD
{
    partial class UClogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UClogin));
            this.label4 = new System.Windows.Forms.Label();
            this.parolaLogare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 49);
            this.label4.TabIndex = 5;
            this.label4.Text = "Personal Autorizat";
            // 
            // parolaLogare
            // 
            this.parolaLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.parolaLogare.Location = new System.Drawing.Point(353, 172);
            this.parolaLogare.Name = "parolaLogare";
            this.parolaLogare.PasswordChar = '*';
            this.parolaLogare.Size = new System.Drawing.Size(247, 26);
            this.parolaLogare.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(312, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "       ";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameBox.Location = new System.Drawing.Point(353, 140);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(247, 26);
            this.usernameBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(310, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "       ";
            // 
            // butonLogin
            // 
            this.butonLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butonLogin.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonLogin.Location = new System.Drawing.Point(393, 213);
            this.butonLogin.Name = "butonLogin";
            this.butonLogin.Size = new System.Drawing.Size(178, 43);
            this.butonLogin.TabIndex = 6;
            this.butonLogin.Text = "Log In";
            this.butonLogin.UseVisualStyleBackColor = false;
            this.butonLogin.Click += new System.EventHandler(this.butonLogin_Click);
            // 
            // UClogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parolaLogare);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.butonLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "UClogin";
            this.Size = new System.Drawing.Size(1222, 656);
            this.Load += new System.EventHandler(this.UClogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parolaLogare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butonLogin;
    }
}
