
namespace ProiectAPD
{
    partial class ManageAngajati
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
            this.tabelAngajati = new System.Windows.Forms.DataGridView();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.prenumeBox = new System.Windows.Forms.TextBox();
            this.parolaBox = new System.Windows.Forms.TextBox();
            this.butonInserareAngajat = new System.Windows.Forms.Button();
            this.butonModificaAngajat = new System.Windows.Forms.Button();
            this.butonStergeAngajat = new System.Windows.Forms.Button();
            this.numeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGradAcces = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelAngajati
            // 
            this.tabelAngajati.AllowUserToAddRows = false;
            this.tabelAngajati.AllowUserToDeleteRows = false;
            this.tabelAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelAngajati.Location = new System.Drawing.Point(158, 0);
            this.tabelAngajati.Name = "tabelAngajati";
            this.tabelAngajati.ReadOnly = true;
            this.tabelAngajati.Size = new System.Drawing.Size(692, 317);
            this.tabelAngajati.TabIndex = 0;
            this.tabelAngajati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelAngajati_CellClick);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(158, 338);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(177, 20);
            this.emailBox.TabIndex = 1;
            // 
            // prenumeBox
            // 
            this.prenumeBox.Location = new System.Drawing.Point(277, 370);
            this.prenumeBox.Name = "prenumeBox";
            this.prenumeBox.Size = new System.Drawing.Size(177, 20);
            this.prenumeBox.TabIndex = 3;
            // 
            // parolaBox
            // 
            this.parolaBox.Location = new System.Drawing.Point(406, 338);
            this.parolaBox.Name = "parolaBox";
            this.parolaBox.Size = new System.Drawing.Size(177, 20);
            this.parolaBox.TabIndex = 4;
            // 
            // butonInserareAngajat
            // 
            this.butonInserareAngajat.Location = new System.Drawing.Point(201, 439);
            this.butonInserareAngajat.Name = "butonInserareAngajat";
            this.butonInserareAngajat.Size = new System.Drawing.Size(134, 40);
            this.butonInserareAngajat.TabIndex = 5;
            this.butonInserareAngajat.Text = "Insereaza";
            this.butonInserareAngajat.UseVisualStyleBackColor = true;
            this.butonInserareAngajat.Click += new System.EventHandler(this.butonInserareAngajat_Click);
            // 
            // butonModificaAngajat
            // 
            this.butonModificaAngajat.Location = new System.Drawing.Point(426, 439);
            this.butonModificaAngajat.Name = "butonModificaAngajat";
            this.butonModificaAngajat.Size = new System.Drawing.Size(134, 40);
            this.butonModificaAngajat.TabIndex = 6;
            this.butonModificaAngajat.Text = "Modifica";
            this.butonModificaAngajat.UseVisualStyleBackColor = true;
            this.butonModificaAngajat.Click += new System.EventHandler(this.butonModificaAngajat_Click);
            // 
            // butonStergeAngajat
            // 
            this.butonStergeAngajat.Location = new System.Drawing.Point(641, 439);
            this.butonStergeAngajat.Name = "butonStergeAngajat";
            this.butonStergeAngajat.Size = new System.Drawing.Size(134, 40);
            this.butonStergeAngajat.TabIndex = 7;
            this.butonStergeAngajat.Text = "Sterge";
            this.butonStergeAngajat.UseVisualStyleBackColor = true;
            this.butonStergeAngajat.Click += new System.EventHandler(this.butonStergeAngajat_Click);
            // 
            // numeBox
            // 
            this.numeBox.Location = new System.Drawing.Point(673, 338);
            this.numeBox.Name = "numeBox";
            this.numeBox.Size = new System.Drawing.Size(177, 20);
            this.numeBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prenume";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxGradAcces
            // 
            this.comboBoxGradAcces.FormattingEnabled = true;
            this.comboBoxGradAcces.Items.AddRange(new object[] {
            "Administrator",
            "Angajat"});
            this.comboBoxGradAcces.Location = new System.Drawing.Point(589, 371);
            this.comboBoxGradAcces.Name = "comboBoxGradAcces";
            this.comboBoxGradAcces.Size = new System.Drawing.Size(177, 21);
            this.comboBoxGradAcces.TabIndex = 13;
            this.comboBoxGradAcces.SelectedIndexChanged += new System.EventHandler(this.comboBoxGradAcces_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Grad Acces";
            // 
            // ManageAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGradAcces);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeBox);
            this.Controls.Add(this.butonStergeAngajat);
            this.Controls.Add(this.butonModificaAngajat);
            this.Controls.Add(this.butonInserareAngajat);
            this.Controls.Add(this.parolaBox);
            this.Controls.Add(this.prenumeBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.tabelAngajati);
            this.Name = "ManageAngajati";
            this.Size = new System.Drawing.Size(1068, 515);
            this.Load += new System.EventHandler(this.ManageAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelAngajati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelAngajati;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox prenumeBox;
        private System.Windows.Forms.TextBox parolaBox;
        private System.Windows.Forms.Button butonInserareAngajat;
        private System.Windows.Forms.Button butonModificaAngajat;
        private System.Windows.Forms.Button butonStergeAngajat;
        private System.Windows.Forms.TextBox numeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGradAcces;
        private System.Windows.Forms.Label label5;
    }
}
