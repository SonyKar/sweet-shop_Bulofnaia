using System.Collections;
using Bulofnaia.API.Entities;
using MySql.Data.MySqlClient;

namespace Bulofnaia.API.Repositories
{
    public class UserRepository
    {
        public static void InsertUser(User user)
        {
            DatabaseInitializer.RunQuery($"INSERT INTO user (first_name, last_name, position, username, password) VALUES ('{user.FirstName}','{user.LastName}','{user.Position}', '{user.Username}', '{user.Password}')");
        }

        public static void DeleteUserById(int id)
        {
            DatabaseInitializer.RunQuery($"DELETE FROM user WHERE user.id = {id}");
        }

        public static bool Auth(string username, string password)
        {
	        string query = $"SELECT * FROM user WHERE `username` = '{username}' AND `password` = '{password}'";
	        MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
	        MySqlDataReader reader = command.ExecuteReader();
	        DatabaseInitializer.CloseConnection();

			return reader.HasRows;
        }

        public static ArrayList SelectUsers()
        {
            string query = $"SELECT * FROM user";
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();

            ArrayList result = new ArrayList();
            while (reader.Read())
            {
                result.Add(new User
                {
                    Id = (int)reader["id"],
                    FirstName = (string)reader["first_name"],
                    LastName = (string)reader["last_name"],
                    Position = (string)reader["position"],
                    Username = (string)reader["username"],
                    Password = (string)reader["password"],
				});
            }

            DatabaseInitializer.CloseConnection();
            return result;
        }
    }
}