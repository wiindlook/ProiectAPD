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
    public partial class UClogin : UserControl
    {

        public UClogin()
        {
            InitializeComponent();
        }



        private void butonLogin_Click(object sender, EventArgs e)
        {

            Angajati angj = new Angajati();
            angj.Email = usernameBox.Text;
            angj.Parola = Vam.Encode(parolaLogare.Text);

            MagazinDAO.logare(angj);
                if (Vam.loginAdmin == true || Vam.loginAngajat == true)
                {
                    HomeCenter.Instance.PnlContainer.Controls.Clear();
                    HomeCenter.Instance.afisareMeniu();
                }
            

            usernameBox.Text = "";
            parolaLogare.Text = "";
          

        }

        private void UClogin_Load(object sender, EventArgs e)
        {
            

        }
    }
}
