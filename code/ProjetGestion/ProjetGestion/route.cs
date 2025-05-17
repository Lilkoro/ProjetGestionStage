using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion
{
    public class Entreprise
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string profilPic { get; set; }
    }

    public class infoElv
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string NomPoste { get; set; }
        public string sectionOption { get; set; }
        public string rueElv { get; set; }
        public string cpElv { get; set; }
        public string villeElv { get; set; }
        public int idCls { get; set; }
        public int idCpt { get; set; }
        public string urlPortfolio { get; set; }
        public string pathCV { get; set; }
        public string tags { get; set; }
        public string lieuTravail { get; set; }


    }

    public class  Specialite
    {
        public string Nom { get; set; }
    }

    public class  lieuTravail
    {
        public string Nom { get; set; }
    }

    public static class Session
    {
        public static int IdUtilisateur { get; set; }
        public static string pathUtilisateur { get; set; }
        public static void resetUser()
        {
            Session.IdUtilisateur = 0;
        }
    }

    public class API
    {
        // Création d'un connecteur, une requête SQL pour récupérer les utilisateurs pouvant se connecter, passage des info dans les Objets.
        static string connectionString = "Server=localhost;Port=3306;Database=gestionstage;Uid=root;Pwd=";
        static MySqlConnection conn = new MySqlConnection(connectionString);
        // Déclaration de la liste d'utilisateurs en public
        public List<User> users { get; private set; } = new List<User>();
        public List<Entreprise> Entreprises { get; private set;} = new List<Entreprise>();
        public List<Specialite> Specialite { get; private set; } = new List<Specialite>();
        public List<lieuTravail> lieuTravail { get; private set; } = new List<lieuTravail>();

        public List<infoElv> infoElv { get; private set; } = new List<infoElv>();
        public MySqlConnection getConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public List<User> GetUsersFromDatabase()
        {
            try
            {
                string selectUsers = "SELECT * FROM compte";
                MySqlCommand command = new MySqlCommand(selectUsers, conn);
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                // Remplir la liste avec les utilisateurs
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string login = reader["login"].ToString();
                    string password = reader["password"].ToString();
                    string picPath = reader["profilPath"].ToString();

                    users.Add(new User { Id = id, Login = login, Password = password, profilPic = picPath});
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return users;
        }
        public List<User> GetSessionUserFromDatabase(int SessionId)
        {
            try
            {
                string selectUsers = "SELECT * FROM compte where id = " + SessionId;
                MySqlCommand command = new MySqlCommand(selectUsers, conn);
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                // Remplir la liste avec les utilisateurs
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string login = reader["login"].ToString();
                    string password = reader["password"].ToString();
                    string picPath = reader["profilPath"].ToString();
                    Console.WriteLine("=====================>" + picPath);

                    users.Add(new User { Id = id, Login = login, Password = password, profilPic = picPath });
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return users;
        }
        public List<infoElv> GetCurrentStudentInfo(int sessiondId)
        {
            try
            {
                int id = Session.IdUtilisateur;
                MySqlConnection conn = getConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(null, conn);
                cmd.CommandText = "Select * FROM eleve where idCpt = @id";
                MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.Int32, 0);
                cmd.Parameters.Add(idParam);
                cmd.Prepare();
                cmd.Parameters[0].Value = id;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idelv = int.Parse(reader["idElv"].ToString());
                    string nom = reader["nomElv"].ToString();
                    string prenom = reader["prenomElv"].ToString();
                    string email = reader["email"].ToString();
                    string tel = reader["tel"].ToString();

                    infoElv.Add(new infoElv { Id = idelv, Nom = nom, Prenom = prenom, Email = email, Tel = tel });
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return infoElv;
        }
        public List<Specialite> GetSpecialites()
        {
            try
            {
                string selectSpecialite = "SELECT * FROM specialite";
                MySqlCommand command = new MySqlCommand(selectSpecialite, conn);
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // Remplir la liste avec les utilisateurs
                while (reader.Read())
                {
                    string nom = reader["nom"].ToString();
                    Specialite.Add(new Specialite { Nom = nom });
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Specialite;
        }
        public List<lieuTravail> GetTravails() {
            try
            {
                string selectTravail = "SELECT * FROM lieuTravail";
                MySqlCommand command = new MySqlCommand(selectTravail, conn);
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // Remplir la liste avec les utilisateurs
                while (reader.Read())
                {
                    string nom = reader["nom"].ToString();
                    lieuTravail.Add(new lieuTravail { Nom = nom });
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lieuTravail;

        }

    }

}
