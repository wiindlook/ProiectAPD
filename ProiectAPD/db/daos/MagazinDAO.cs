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
            cmd.CommandText = "select acces from angajati where email=@email AND parola=@parola";
            cmd.Parameters.AddWithValue("@email", angj.Email);
            cmd.Parameters.AddWithValue("@parola", angj.Parola);
            MySqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                if ((string)data["acces"] == Vam.rolAdmin)
                {
                    MessageBox.Show("Logarea a avut loc cu succes", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vam.loginAdmin = true;
                }

                else if ((string)data["acces"] == Vam.rolAngajat)
                {
                    MessageBox.Show("Logarea a avut loc cu succes", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vam.loginAngajat = true;
                }
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
                MessageBox.Show("Inserarea nu a avut loc", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                
                MessageBox.Show("Inserarea a avut loc cu succes", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            cmd.CommandText = "DELETE FROM produse WHERE denumire=@denumire AND descriere=@descriere AND cantitate=@cantitate AND pret=@pret";
            cmd.Parameters.AddWithValue("@denumire", prd.Denumire);
            cmd.Parameters.AddWithValue("@descriere", prd.Descriere);
            cmd.Parameters.AddWithValue("@cantitate", prd.Cantitate);
            cmd.Parameters.AddWithValue("@pret", prd.Pret);

            MySqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                MessageBox.Show("Stergerea nu a avut loc", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                
                MessageBox.Show("Stergerea a avut loc cu succes", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            cmd.CommandText = "UPDATE produse SET denumire=@denumire,descriere=@descriere,cantitate=@cantitate,pret=@pret WHERE id=@id ";
            cmd.Parameters.AddWithValue("@denumire", prd.Denumire);
            cmd.Parameters.AddWithValue("@descriere", prd.Descriere);
            cmd.Parameters.AddWithValue("@cantitate", prd.Cantitate);
            cmd.Parameters.AddWithValue("@pret", prd.Pret);
            cmd.Parameters.AddWithValue("@id", prd.Id);
            try
            {
                if (cmd.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Modificarea nu a avut loc!");
                }

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }


            con.Close();

        }
        public static DataTable afisareAngajati(Angajati angj)
        {
            MySqlConnection con = DBConnection.getConnection();
            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            string instructiune = "select *from angajati";
            MySqlDataAdapter adpt = new MySqlDataAdapter(instructiune, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public static void insertAngajati(Angajati angj)
        {
            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO angajati(email,parola,nume,prenume,acces) VALUES(@email,@parola,@nume,@prenume,@acces)";
            cmd.Parameters.AddWithValue("@email", angj.Email);
            cmd.Parameters.AddWithValue("@parola", angj.Parola);
            cmd.Parameters.AddWithValue("@nume", angj.Nume);
            cmd.Parameters.AddWithValue("@prenume", angj.Prenume);
            cmd.Parameters.AddWithValue("@acces", angj.Acces);
        
            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Modificarea nu s-a putut face");
            }
            con.Close();
        }

        public static void stergeAngajat(Angajati angj)
        {
            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "DELETE FROM angajati WHERE email=@email AND parola=@parola AND nume=@nume AND prenume=@prenume AND acces=@acces ";
            cmd.Parameters.AddWithValue("@email", angj.Email);
            cmd.Parameters.AddWithValue("@parola", angj.Parola);
            cmd.Parameters.AddWithValue("@nume", angj.Nume);
            cmd.Parameters.AddWithValue("@prenume", angj.Prenume);
            cmd.Parameters.AddWithValue("@acces", angj.Acces);
            MySqlDataReader data = cmd.ExecuteReader();
            if (data.Read())
            {
                MessageBox.Show("Stergerea nu a avut loc", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                MessageBox.Show("Stergerea a avut loc cu succes", "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
        public static void updateAngajat(Angajati angj)
        {

            MySqlConnection con = DBConnection.getConnection();

            if (con == null)
            {
                throw new Exception("Conexiunea la baza de date nu s-a realizat.");
            }

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE Angajati SET email=@email,parola=@parola,nume=@nume,prenume=@prenume,acces=@acces WHERE id=@id ";
            cmd.Parameters.AddWithValue("@email", angj.Email);
            cmd.Parameters.AddWithValue("@parola", angj.Parola);
            cmd.Parameters.AddWithValue("@nume", angj.Nume);
            cmd.Parameters.AddWithValue("@prenume", angj.Prenume);
            cmd.Parameters.AddWithValue("@acces", angj.Acces);
            cmd.Parameters.AddWithValue("@id", angj.Id);
            try
            {
                if (cmd.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Modificarea nu a avut loc!");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            con.Close();

        }
    }
}
