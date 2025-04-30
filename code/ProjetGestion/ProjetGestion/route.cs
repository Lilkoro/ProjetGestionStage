using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion
{
    class route
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
        }
        public class API
        {        
            // Création d'un connecteur, une requête SQL pour récupérer les utilisateurs pouvant se connecter, passage des info dans les Objets.
            string connectionString = "Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=";
            string selectUsers = "SELECT * FROM compte";
            // Déclaration de la liste d'utilisateurs en public
            public List<User> users { get; private set; } = new List<User>();
            public List<Entreprise> Entreprises { get; private set;} = new List<Entreprise>();
            public List<Entreprise> getAllEntreprise()
            {

            }

            public List<User> GetUsersFromDatabase()
            {

                try
                {
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    MySqlCommand command = new MySqlCommand(selectUsers, conn);
                    conn.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    // Remplir la liste avec les utilisateurs
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string login = reader["login"].ToString();
                        string password = reader["password"].ToString();

                        users.Add(new User { Id = id, Login = login, Password = password});
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
        }

    }
}
