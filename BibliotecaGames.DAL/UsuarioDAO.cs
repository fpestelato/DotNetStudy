using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGames.Entities;
using MySql.Data.MySqlClient;

namespace BibliotecaGames.DAL
{
    public class UsuarioDAO
    {
        public Usuario ObterUsuarioESenha(string nomeUsuario, string senha) {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexao.connection;
                comando.CommandText = "SELECT * FROM tb_usuario WHERE NomeUsuario = @usuario and SenhaUsuario = @senha";

                comando.Parameters.AddWithValue("@usuario", nomeUsuario);
                comando.Parameters.AddWithValue("@senha", senha);

                Conexao.Conectar();

                MySqlDataReader reader = comando.ExecuteReader();

                Usuario usuario = null;

                while (reader.Read())
                {
                    usuario = new Usuario();

                    usuario.Id = Convert.ToInt32(reader["CodUsuario"]);
                    usuario.NomeUsuario = reader["NomeUsuario"].ToString();
                    usuario.Senha = reader["SenhaUsuario"].ToString();
                    usuario.Perfil = Convert.ToChar(reader["PerfilUsuario"]);
                }

                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            };
        }
    }
}
