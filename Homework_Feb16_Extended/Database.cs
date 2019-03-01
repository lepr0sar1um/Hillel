using System;
using MySql.Data.MySqlClient;

namespace Homework_Feb16_part2
{
    public class Database
    {
        private const string ConnStr = "server=localhost;user=lepre;database=Homework_Feb16;password=password";

        private void OpenConnection()
        {
            var connection = new MySqlConnection(ConnStr);

            try
            {
                connection.Open();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void CloseConnection()
        {
            var connection = new MySqlConnection(ConnStr);
            connection.Close();
        }
    }
}