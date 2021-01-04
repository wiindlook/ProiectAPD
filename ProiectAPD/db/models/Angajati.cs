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

        public string Email { get => email; set => email = value; }
        public string Parola { get => parola; set => parola = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Acces { get => acces; set => acces = value; }
        public int Id { get => id; set => id = value; }
    }
}
