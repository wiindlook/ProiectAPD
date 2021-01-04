using ProiectAPD.db.daos;
using ProiectAPD.db.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAPD
{
    public partial class ManageAngajati : UserControl
    {
        public ManageAngajati()
        {
            InitializeComponent();
        }

        private void ManageAngajati_Load(object sender, EventArgs e)
        {
            Angajati angj = new Angajati();
            tabelAngajati.DataSource = MagazinDAO.afisareAngajati(angj);
        }
        public void arataAngajati()
        {
            Angajati angj = new Angajati();
            tabelAngajati.DataSource = MagazinDAO.afisareAngajati(angj);
        }

        private void butonInserareAngajat_Click(object sender, EventArgs e)
        {
            Angajati angj = new Angajati();
            angj.Email = emailBox.Text;
            angj.Parola = Vam.Encode(parolaBox.Text);
            angj.Nume = numeBox.Text;
            angj.Prenume = prenumeBox.Text;
            angj.Acces = comboBoxGradAcces.GetItemText(comboBoxGradAcces.SelectedItem);
            MagazinDAO.insertAngajati(angj);
            emailBox.Text="";
            parolaBox.Text="";
            numeBox.Text="";
            prenumeBox.Text = "" ;
            angj.Email = "";
            arataAngajati();

        }

        private void butonModificaAngajat_Click(object sender, EventArgs e)
        {
            Angajati angj = new Angajati();
            angj.Id = Vam.valIdAngajat;
            angj.Email = emailBox.Text;
            angj.Parola =Vam.Encode(parolaBox.Text);
            angj.Nume = numeBox.Text;
            angj.Prenume = prenumeBox.Text;
            angj.Acces = comboBoxGradAcces.GetItemText(comboBoxGradAcces.SelectedItem);
            MagazinDAO.updateAngajat(angj);
            emailBox.Text = "";
            parolaBox.Text = "";
            numeBox.Text = "";
            prenumeBox.Text = "";
            angj.Email = "";
            arataAngajati();
        }
    

        private void butonStergeAngajat_Click(object sender, EventArgs e)
        {
            Angajati angj = new Angajati();
            angj.Email = emailBox.Text;
            angj.Parola = parolaBox.Text;
            angj.Nume = numeBox.Text;
            angj.Prenume = prenumeBox.Text;
            angj.Acces = comboBoxGradAcces.GetItemText(comboBoxGradAcces.SelectedItem);
            MagazinDAO.stergeAngajat(angj);
            emailBox.Text = "";
            parolaBox.Text = "";
            numeBox.Text = "";
            prenumeBox.Text = "";
            arataAngajati();
        }

        private void comboBoxGradAcces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabelAngajati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = tabelAngajati.Rows[index];
            Vam.valIdAngajat = int.Parse(selectedRow.Cells[0].Value.ToString());
            emailBox.Text = selectedRow.Cells[1].Value.ToString();
            parolaBox.Text = selectedRow.Cells[2].Value.ToString();
            numeBox.Text = selectedRow.Cells[3].Value.ToString();
            prenumeBox.Text = selectedRow.Cells[4].Value.ToString();
            comboBoxGradAcces.Text= selectedRow.Cells[5].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
