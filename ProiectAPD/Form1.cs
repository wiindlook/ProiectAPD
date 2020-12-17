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
    public partial class Form1 : Form
    {

        static Form1 _obj;
        public static Form1 Instance //creaza un obiect de tip form pentru a putea acccesa functiile din form;
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1(); 
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }
        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
                  _obj = this; 
                UClogin uc = new UClogin();
                uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            panelContainer.Controls["UClogin"].BringToFront();
            





        }
    }

     
    }

