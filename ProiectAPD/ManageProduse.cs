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

        private void button1_Click(object sender, EventArgs e)
        {
            Produse prd = new Produse();
           prd.Denumire = textBox1.Text;
            prd.Descriere = textBox2.Text;
            prd.Cantitate = int.Parse(textBox3.Text);
            prd.Pret = int.Parse(textBox4.Text);
            MagazinDAO.insert(prd);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            
        }
    }
}
