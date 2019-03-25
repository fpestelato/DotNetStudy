using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGames.DAL;
using BibliotecaGames.Entities;
using BibliotecaGames.BLL.Excecoes;

namespace BibliotecaGames.BLL.Autenticacao
{
    public class LoginBo
    {
        private UsuarioDAO _usuarioDao;
        public Usuario ObterUsuarioParaLogar(string nomeUsuario, string senha)
        {
            _usuarioDao = new UsuarioDAO();
            Usuario usuario = _usuarioDao.ObterUsuarioESenha(nomeUsuario, senha);

            if (usuario == null)
            {
                throw new UsuarioNaoCadastradoException();
            }

            return usuario;              
        }
    }
}
