using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAPD.db.models
{
    class Angajati
    {
        private string email;
        private string parola;
        private string nume;
        private string prenume;
        private string acces;
        private int id;

        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }
        public string Parola
        {
            set
            {
                parola = value;
            }
            get
            {
                return parola;
            }
        }
        public string Nume
        {
            set
            {
                nume = value;
            }
            get
            {
                return nume;
            }
        }
        public string Prenume
        {
            set
            {
                prenume = value;
            }
            get
            {
                return prenume;
            }
        }
        public string Acces
        {
            set
            {
                acces = value;
            }
            get
            {
                return acces;
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
    }
}
