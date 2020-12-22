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

        public int Cantitate { get => cantitate; set => cantitate = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public int Pret { get => pret; set => pret = value; }
        public int Id { get => id; set => id = value; }
    }
}
