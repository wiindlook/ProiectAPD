
namespace ProiectAPD
{
    partial class ManageProduse
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
            this.tabelProduse = new System.Windows.Forms.DataGridView();
            this.denumireBox = new System.Windows.Forms.TextBox();
            this.cantitateBox = new System.Windows.Forms.TextBox();
            this.descriereBox = new System.Windows.Forms.TextBox();
            this.pretBox = new System.Windows.Forms.TextBox();
            this.butonInsereaza = new System.Windows.Forms.Button();
            this.butonModifica = new System.Windows.Forms.Button();
            this.butonSterge = new System.Windows.Forms.Button();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelProduse
            // 
            this.tabelProduse.AllowUserToAddRows = false;
            this.tabelProduse.AllowUserToDeleteRows = false;
            this.tabelProduse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelProduse.Location = new System.Drawing.Point(139, 0);
            this.tabelProduse.Name = "tabelProduse";
            this.tabelProduse.ReadOnly = true;
            this.tabelProduse.Size = new System.Drawing.Size(712, 302);
            this.tabelProduse.TabIndex = 0;
            this.tabelProduse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelProduse_CellClick);
            // 
            // denumireBox
            // 
            this.denumireBox.Location = new System.Drawing.Point(221, 326);
            this.denumireBox.Name = "denumireBox";
            this.denumireBox.Size = new System.Drawing.Size(205, 20);
            this.denumireBox.TabIndex = 1;
            // 
            // cantitateBox
            // 
            this.cantitateBox.Location = new System.Drawing.Point(550, 326);
            this.cantitateBox.Name = "cantitateBox";
            this.cantitateBox.Size = new System.Drawing.Size(205, 20);
            this.cantitateBox.TabIndex = 2;
            // 
            // descriereBox
            // 
            this.descriereBox.Location = new System.Drawing.Point(221, 368);
            this.descriereBox.Multiline = true;
            this.descriereBox.Name = "descriereBox";
            this.descriereBox.Size = new System.Drawing.Size(205, 42);
            this.descriereBox.TabIndex = 3;
            // 
            // pretBox
            // 
            this.pretBox.Location = new System.Drawing.Point(550, 378);
            this.pretBox.Name = "pretBox";
            this.pretBox.Size = new System.Drawing.Size(205, 20);
            this.pretBox.TabIndex = 4;
            // 
            // butonInsereaza
            // 
            this.butonInsereaza.Location = new System.Drawing.Point(221, 444);
            this.butonInsereaza.Name = "butonInsereaza";
            this.butonInsereaza.Size = new System.Drawing.Size(105, 50);
            this.butonInsereaza.TabIndex = 5;
            this.butonInsereaza.Text = "Insereaza";
            this.butonInsereaza.UseVisualStyleBackColor = true;
            this.butonInsereaza.Click += new System.EventHandler(this.butonInsereaza_Click);
            // 
            // butonModifica
            // 
            this.butonModifica.Location = new System.Drawing.Point(438, 444);
            this.butonModifica.Name = "butonModifica";
            this.butonModifica.Size = new System.Drawing.Size(106, 50);
            this.butonModifica.TabIndex = 6;
            this.butonModifica.Text = "Modifica";
            this.butonModifica.UseVisualStyleBackColor = true;
            this.butonModifica.Click += new System.EventHandler(this.butonModifica_Click);
            // 
            // butonSterge
            // 
            this.butonSterge.Location = new System.Drawing.Point(649, 444);
            this.butonSterge.Name = "butonSterge";
            this.butonSterge.Size = new System.Drawing.Size(106, 50);
            this.butonSterge.TabIndex = 7;
            this.butonSterge.Text = "Sterge";
            this.butonSterge.UseVisualStyleBackColor = true;
            this.butonSterge.Click += new System.EventHandler(this.butonSterge_Click);
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(163, 329);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(52, 13);
            this.labelDenumire.TabIndex = 9;
            this.labelDenumire.Text = "Denumire";
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Location = new System.Drawing.Point(167, 385);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(52, 13);
            this.labelDescriere.TabIndex = 10;
            this.labelDescriere.Text = "Descriere";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(495, 329);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(49, 13);
            this.labelCantitate.TabIndex = 11;
            this.labelCantitate.Text = "Cantitate";
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(509, 385);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(26, 13);
            this.labelPret.TabIndex = 12;
            this.labelPret.Text = "Pret";
            // 
            // ManageProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.labelDescriere);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.butonSterge);
            this.Controls.Add(this.butonModifica);
            this.Controls.Add(this.butonInsereaza);
            this.Controls.Add(this.pretBox);
            this.Controls.Add(this.descriereBox);
            this.Controls.Add(this.cantitateBox);
            this.Controls.Add(this.denumireBox);
            this.Controls.Add(this.tabelProduse);
            this.Name = "ManageProduse";
            this.Size = new System.Drawing.Size(1068, 515);
            this.Load += new System.EventHandler(this.ManageProduse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelProduse;
        private System.Windows.Forms.TextBox denumireBox;
        private System.Windows.Forms.TextBox cantitateBox;
        private System.Windows.Forms.TextBox descriereBox;
        private System.Windows.Forms.TextBox pretBox;
        private System.Windows.Forms.Button butonInsereaza;
        private System.Windows.Forms.Button butonModifica;
        private System.Windows.Forms.Button butonSterge;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label labelDescriere;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Label labelPret;
    }
}
