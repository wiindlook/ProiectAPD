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



            _obj = this;
            UClogin uc = new UClogin();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            panelContainer.Controls["UClogin"].BringToFront();


        }
    }


}

