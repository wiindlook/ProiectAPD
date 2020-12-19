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
    public partial class HomeCenter : Form
    {

        static HomeCenter _obj;
        public static HomeCenter Instance //creaza un obiect de tip form pentru a putea acccesa functiile din form;
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new HomeCenter();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public HomeCenter()
        {
            InitializeComponent();
           
            
        }

        private void HomeCenter_Load(object sender, EventArgs e)
        {
            panelButoane.Hide();
            _obj = this;
                UClogin uc = new UClogin();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
                panelContainer.Controls["UClogin"].BringToFront();
           
        }
    
    private void butonAfisare_Click(object sender, EventArgs e)
        {   
            _obj = this;
            AfisareTabelProduse atp = new AfisareTabelProduse();
            atp.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(atp);
            panelContainer.Controls["AfisareTabelProduse"].BringToFront();            
        }
         public  void afisareMeniuAngajat()
        {
            panelButoane.Show();
        }

        private void butonActiuni_Click(object sender, EventArgs e)
        {
            _obj = this;
            ManageProduse mp = new ManageProduse();
            mp.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(mp);
            panelContainer.Controls["ManageProduse"].BringToFront();
        }
    }


}

