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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void butonLogin_Click(object sender, EventArgs e)
        {
            Angajati angj = new Angajati();
            angj.Email = usernameBox.Text;
            angj.Parola = parolaBox.Text;

           MagazinDAO.logare(angj);

            usernameBox.Text = "";
            parolaBox.Text = "";

            
        }
    }

     
    }

