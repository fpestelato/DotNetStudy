using BibliotecaGames.BLL.Autenticacao;
using BibliotecaGames.BLL.Excecoes;
using BibliotecaGames.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BibliotecaGames.Site.Login
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBo _logingBo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            _logingBo = new LoginBo();

            string nomeUsuario = TxtUsuario.Text;
            string senha = txtSenha.Text;

            try
            {
                Usuario usuario = _logingBo.ObterUsuarioParaLogar(nomeUsuario, senha);
                lblStatus.Text = "Autenticação realizada com sucesso!";
            }
            catch (UsuarioNaoCadastradoException)
            {
                lblStatus.Text = "Usuário não cadastrado";
            } catch(Exception exc)
            {
                lblStatus.Text = "Ocorreu um erro inesperado! Contatar o administrador do sistema: \n " + exc.Message;
            }

            
        }
    }
}