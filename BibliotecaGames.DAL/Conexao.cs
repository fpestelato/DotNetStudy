using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BibliotecaGames.DAL
{
    public class Conexao
    {
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["STRING_CONNECTION"].ConnectionString;
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public static void Conectar()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
