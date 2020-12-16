using MySql.Data.MySqlClient;
using ProiectAPD.db.models;
using ProiectAPD.db.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAPD.db.daos
{
    class MagazinDAO
    {





        public static void logare(Angajati angj)
        {
            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select *from angajati where email=@email AND parola=@parola";
            cmd.Parameters.AddWithValue("@email", angj.Email);
            cmd.Parameters.AddWithValue("@parola", angj.Parola);
            MySqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                MessageBox.Show("Logarea a avut loc cu succes","Event",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    

            }   
            else
            {
                MessageBox.Show("Logarea nu a avut loc", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            

            con.Close();



        }


        public static void insert(Produse prd)
        {
            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO highscores(denumire, descriere,cantiate,pret) VALUES(@denumire, @descriere,@cantiate,@pret)";
            cmd.Parameters.AddWithValue("@denumire", prd.Denumire);
            cmd.Parameters.AddWithValue("@descriere", prd.Descriere);
            cmd.Parameters.AddWithValue("@cantiate", prd.Cantitate);
            cmd.Parameters.AddWithValue("@pret", prd.Pret);

            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Inserarea nu s-a putut face.");
            }

            con.Close();
        }
        public static void sterge(Produse prd)
        {
            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "DELETE FROM highscores WHERE denumire=@denumire AND descriere=@descriere AND cantiate=@cantitate AND pret=@pret";
            cmd.Parameters.AddWithValue("@denumire", prd.Denumire);
            cmd.Parameters.AddWithValue("@descriere", prd.Descriere);
            cmd.Parameters.AddWithValue("@cantiate", prd.Cantitate);
            cmd.Parameters.AddWithValue("@pret", prd.Pret);



            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Stergerea nu s-a putut face.");
            }

            con.Close();

        }
        public static void update(Produse prd)
        {

            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE highscores SET descriere=@descriere,cantiate=@cantitate,pret=@pret WHERE denumire=@denumire ";
            cmd.Parameters.AddWithValue("@denumire", prd.Denumire);
            cmd.Parameters.AddWithValue("@descriere", prd.Descriere);
            cmd.Parameters.AddWithValue("@cantiate", prd.Cantitate);
            cmd.Parameters.AddWithValue("@pret", prd.Pret);


            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Modificarea nu s-a putut face");
            }

            con.Close();

        }
    }
}
