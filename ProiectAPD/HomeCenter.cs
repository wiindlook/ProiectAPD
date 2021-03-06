﻿using ProiectAPD.db.daos;
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
            panelSus.Hide();
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
         public  void afisareMeniu()
        {
            panelButoane.Show();
            panelSus.Show();
        }

        private void butonActiuni_Click(object sender, EventArgs e)
        {
            _obj = this;
            ManageProduse mp = new ManageProduse();
            mp.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(mp);
            panelContainer.Controls["ManageProduse"].BringToFront();
        }

        private void butonSetari_Click(object sender, EventArgs e)
        {
            _obj = this;
            Setari set = new Setari();
            set.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(set);
            panelContainer.Controls["Setari"].BringToFront();
        }

        private void butonAdministratie_Click(object sender, EventArgs e)
        {
            if(Vam.loginAdmin==true)
            {
                _obj = this;
                ManageAngajati ma = new ManageAngajati();
                ma.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(ma);
                panelContainer.Controls["ManageAngajati"].BringToFront();
            }
            else
                if(Vam.loginAngajat==true)
            {
                MessageBox.Show("Nu aveti acces la aceasta optiune!", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butonLogout_Click(object sender, EventArgs e)
        {
            DialogResult resDiag = MessageBox.Show("Esti sigur ca vrei sa te deloghezi?",
                                "DELOGARE", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (resDiag == DialogResult.OK)
            {
                panelButoane.Hide();
                panelSus.Hide();
                _obj = this;
                UClogin uc = new UClogin();
                uc.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(uc);
                panelContainer.Controls["UClogin"].BringToFront();
            }
            if (resDiag == DialogResult.Cancel)
            {
                return;
            }


      
            
        }
    }


}

