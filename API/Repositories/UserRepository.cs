using System.Collections;
using Bulofnaia.API.Entities;
using MySql.Data.MySqlClient;

namespace Bulofnaia.API.Repositories
{
    public class UserRepository
    {
        static void AddUser(User user)
        {
            DatabaseInitializer.RunQuery($"INSERT INTO user (first_name, last_name, position) VALUES ('{user.FirstName}','{user.LastName}','{user.Position}')");
        }

        static void DeleteUserById(int id)
        {
            DatabaseInitializer.RunQuery($"DELETE FROM user WHERE user.id = {id}");
        }

        static ArrayList SelectUsers()
        {
            string query = $"SELECT * FROM user";
            MySqlCommand command = new MySqlCommand(query, DatabaseInitializer.OpenConnection());
            MySqlDataReader reader = command.ExecuteReader();

            ArrayList result = new ArrayList();
            while (reader.Read())
            {
                result.Add(new User()
                {
                    Id = (int)reader["id"],
                    FirstName = (string)reader["first_name"],
                    LastName = (string)reader["last_name"],
                    Position = (string)reader["position"],
                });
            }

            DatabaseInitializer.CloseConnection();
            return result;
        }
    }
}