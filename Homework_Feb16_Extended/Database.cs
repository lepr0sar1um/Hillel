using MySql.Data.MySqlClient;

namespace Homework_Feb16_part2
{
    public class Database
    {
        const string connStr = "server=localhost;user=lepre;database=Homework_Feb16;password=password";

        private void OpenConnection()
        {
            var connection = new MySqlConnection(connStr);
            connection.Open();
        }

        private void CloseConnection()
        {
            var connection = new MySqlConnection(connStr);
            connection.Close();
        }
    }
}