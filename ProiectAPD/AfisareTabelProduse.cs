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
    public partial class AfisareTabelProduse : UserControl
    {
        public AfisareTabelProduse()
        {
            InitializeComponent();
        }

        private void AfisareTabelProduse_Load(object sender, EventArgs e)
        {
            Produse prd = new Produse();
            dataGridView1.DataSource = MagazinDAO.afisare(prd);
        }
    }
}
