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
    public partial class ManageProduse : UserControl
    {
        public ManageProduse()
        {
            InitializeComponent();
        }

        private void butonInsereaza_Click(object sender, EventArgs e)
        {
            Produse prd = new Produse();
            prd.Denumire = denumireBox.Text;
            prd.Descriere = descriereBox.Text;
            prd.Cantitate = int.Parse(cantitateBox.Text);
            prd.Pret = int.Parse(pretBox.Text);
            MagazinDAO.insert(prd);
            denumireBox.Text = "";
            descriereBox.Text = "";
            cantitateBox.Text = "";
            pretBox.Text = "";
            afisareProduse();
        }

        private void butonModifica_Click(object sender, EventArgs e)
        {
            Vam.apasareButon = true;
        }

        private void butonSterge_Click(object sender, EventArgs e)
        {
           Produse prd = (Produse)tabelProduse.SelectedRows[0].DataBoundItem;
            MagazinDAO.sterge(prd);
            afisareProduse();

        }

        private void ManageProduse_Load(object sender, EventArgs e)
        {
            Produse prd = new Produse();
            tabelProduse.DataSource = MagazinDAO.afisare(prd);
        }
        public void afisareProduse()
        {
            Produse prd = new Produse();
            tabelProduse.DataSource = MagazinDAO.afisare(prd);


        }
        

        private void tabelProduse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = tabelProduse.Rows[index];
            denumireBox.Text = selectedRow.Cells[0].Value.ToString();
            descriereBox.Text = selectedRow.Cells[1].Value.ToString();
            cantitateBox.Text = selectedRow.Cells[2].Value.ToString();
            pretBox.Text = selectedRow.Cells[3].Value.ToString();
            if(Vam.apasareButon==true)
            {
                Produse prd = new Produse();
                prd.Denumire = denumireBox.Text;
                prd.Descriere = descriereBox.Text;
                prd.Cantitate = int.Parse(cantitateBox.Text);
                prd.Pret = int.Parse(pretBox.Text);
                MagazinDAO.update(prd);
                afisareProduse();
            }
            
        }
    }
}
