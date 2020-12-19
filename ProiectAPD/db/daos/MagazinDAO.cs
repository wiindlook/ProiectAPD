using MySql.Data.MySqlClient;
using ProiectAPD.db.models;
using ProiectAPD.db.utils;
using System;
using System.Collections.Generic;
using System.Data;
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
                Vam.login = true;
            }   
            else
            {
                MessageBox.Show("Logarea nu a avut loc", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
        public static DataTable afisare(Produse prd)
        {
            MySqlConnection con = DBConnection.getConnection();
            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            string instructiune = "select *from produse";
            MySqlDataAdapter adpt = new MySqlDataAdapter(instructiune,con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
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

            cmd.CommandText = "INSERT INTO produse(denumire,descriere,cantitate,pret) VALUES(@denumire,@descriere,@cantitate,@pret)";
            cmd.Parameters.AddWithValue("@denumire", prd.Denumire);
            cmd.Parameters.AddWithValue("@descriere", prd.Descriere);
            cmd.Parameters.AddWithValue("@cantitate", prd.Cantitate);
            cmd.Parameters.AddWithValue("@pret", prd.Pret);
            MySqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                MessageBox.Show("Inserarea a avut loc cu succes", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Inserarea nu a avut loc", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            MySqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                MessageBox.Show("Stergerea a avut loc cu succes", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Vam.login = true;
            }
            else
            {
                MessageBox.Show("Stergerea nu a avut loc", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


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

            cmd.CommandText = "UPDATE highscores SET denumire=@denumire, descriere=@descriere,cantiate=@cantitate,pret=@pret WHERE id=@id ";
            cmd.Parameters.AddWithValue("@denumire", prd.Denumire);
            cmd.Parameters.AddWithValue("@descriere", prd.Descriere);
            cmd.Parameters.AddWithValue("@cantiate", prd.Cantitate);
            cmd.Parameters.AddWithValue("@pret", prd.Pret);
            cmd.Parameters.AddWithValue("@id", prd.Id);




            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Modificarea nu s-a putut face");
            }

            con.Close();

        }
    }
}
