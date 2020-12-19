using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAPD.db.models
{
    class Produse
    {
        private int cantitate;
        private string denumire;
        private string descriere;
        private int pret;
        private int id;

        public int Cantitate
        {
            set
            {
                cantitate = value;
            }
            get
            {
                return cantitate;
            }
        }

        public string Denumire
        {
            set
            {
                denumire = value;
            }
            get
            {
                return denumire;
            }
        }
        public string Descriere
        {
            set
            {
                descriere = value;
            }
            get
            {
                return descriere;
            }
        }
        public int Pret
        {
            set
            {
                pret = value;
            }
            get
            {
                return pret;
            }
        }
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public override string ToString()
        {
            return "{ denumire: \"" + denumire + "\", descriere: \"" + descriere + "\", cantiate: " + cantitate + ",pret: " + pret + ",id" + id +" }";
        }
    }
}
