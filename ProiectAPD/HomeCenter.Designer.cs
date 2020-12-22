
namespace ProiectAPD
{
    partial class HomeCenter
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelButoane = new System.Windows.Forms.Panel();
            this.tabelButoane = new System.Windows.Forms.TableLayoutPanel();
            this.butonAfisare = new System.Windows.Forms.Button();
            this.butonActiuni = new System.Windows.Forms.Button();
            this.butonAdministratie = new System.Windows.Forms.Button();
            this.butonSetari = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButoane.SuspendLayout();
            this.tabelButoane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(138, 102);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1068, 515);
            this.panelContainer.TabIndex = 0;
            // 
            // panelButoane
            // 
            this.panelButoane.Controls.Add(this.tabelButoane);
            this.panelButoane.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButoane.Location = new System.Drawing.Point(0, 0);
            this.panelButoane.Name = "panelButoane";
            this.panelButoane.Size = new System.Drawing.Size(138, 617);
            this.panelButoane.TabIndex = 1;
            // 
            // tabelButoane
            // 
            this.tabelButoane.ColumnCount = 1;
            this.tabelButoane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabelButoane.Controls.Add(this.butonAfisare, 0, 1);
            this.tabelButoane.Controls.Add(this.butonActiuni, 0, 2);
            this.tabelButoane.Controls.Add(this.butonAdministratie, 0, 3);
            this.tabelButoane.Controls.Add(this.butonSetari, 0, 4);
            this.tabelButoane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelButoane.Location = new System.Drawing.Point(0, 0);
            this.tabelButoane.Name = "tabelButoane";
            this.tabelButoane.RowCount = 6;
            this.tabelButoane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tabelButoane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tabelButoane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tabelButoane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tabelButoane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tabelButoane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tabelButoane.Size = new System.Drawing.Size(138, 617);
            this.tabelButoane.TabIndex = 0;
            // 
            // butonAfisare
            // 
            this.butonAfisare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butonAfisare.Location = new System.Drawing.Point(3, 102);
            this.butonAfisare.Name = "butonAfisare";
            this.butonAfisare.Size = new System.Drawing.Size(132, 93);
            this.butonAfisare.TabIndex = 0;
            this.butonAfisare.Text = "Produse";
            this.butonAfisare.UseVisualStyleBackColor = true;
            this.butonAfisare.Click += new System.EventHandler(this.butonAfisare_Click);
            // 
            // butonActiuni
            // 
            this.butonActiuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butonActiuni.Location = new System.Drawing.Point(3, 201);
            this.butonActiuni.Name = "butonActiuni";
            this.butonActiuni.Size = new System.Drawing.Size(132, 93);
            this.butonActiuni.TabIndex = 1;
            this.butonActiuni.Text = "Actiuni";
            this.butonActiuni.UseVisualStyleBackColor = true;
            this.butonActiuni.Click += new System.EventHandler(this.butonActiuni_Click);
            // 
            // butonAdministratie
            // 
            this.butonAdministratie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butonAdministratie.Location = new System.Drawing.Point(3, 300);
            this.butonAdministratie.Name = "butonAdministratie";
            this.butonAdministratie.Size = new System.Drawing.Size(132, 93);
            this.butonAdministratie.TabIndex = 2;
            this.butonAdministratie.Text = "Administratie";
            this.butonAdministratie.UseVisualStyleBackColor = true;
            this.butonAdministratie.Click += new System.EventHandler(this.butonAdministratie_Click);
            // 
            // butonSetari
            // 
            this.butonSetari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butonSetari.Location = new System.Drawing.Point(3, 399);
            this.butonSetari.Name = "butonSetari";
            this.butonSetari.Size = new System.Drawing.Size(132, 93);
            this.butonSetari.TabIndex = 3;
            this.butonSetari.Text = "Setari";
            this.butonSetari.UseVisualStyleBackColor = true;
            this.butonSetari.Click += new System.EventHandler(this.butonSetari_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(138, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 100);
            this.panel1.TabIndex = 2;
            // 
            // HomeCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButoane);
            this.Controls.Add(this.panelContainer);
            this.Name = "HomeCenter";
            this.Text = "HomeCenter";
            this.Load += new System.EventHandler(this.HomeCenter_Load);
            this.panelButoane.ResumeLayout(false);
            this.tabelButoane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelButoane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tabelButoane;
        private System.Windows.Forms.Button butonAfisare;
        private System.Windows.Forms.Button butonActiuni;
        private System.Windows.Forms.Button butonAdministratie;
        private System.Windows.Forms.Button butonSetari;
    }
}