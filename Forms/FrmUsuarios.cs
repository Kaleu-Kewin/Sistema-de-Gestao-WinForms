using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard.Forms
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            ConfigurarCards();
            ConfigurarGrid();
        }

        private void ConfigurarCards()
        {
            cbCadastrados.ConfigurarCard(
                titulo: "Usuários Cadastrados",
                descricao: "4", 
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["users.png"]
            );

            cbComAcesso.ConfigurarCard(
                titulo: "Com acesso ao sistema",
                descricao: "3", 
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["users.png"]
            );

            cbSemAcesso.ConfigurarCard(
                titulo: "Sem acesso",
                descricao: "1", 
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["users.png"]
            );

            cbAcessoCompleto.ConfigurarCard(
                titulo: "Acesso Completo",
                descricao: "2", 
                estatistica: "",
                cor: Color.Transparent,
                icone: imgIcons.Images["users.png"]
            );
        }

        private void ConfigurarGrid()
        {
            gbUsuarios.ConfigurarGrid(
                titulo: "Usuários Cadastrados", 
                descricao: "4 usuário(s)"
            );

            var data = new List<dynamic>
            {
                new { Codigo = "1", Nome = "USUARIO 01", Email = "email@gmail.com", Perfil = "Administrador", Status = "Ativo" },
                new { Codigo = "2", Nome = "USUARIO 02", Email = "email@gmail.com", Perfil = "Administrador", Status = "Ativo" },
                new { Codigo = "3", Nome = "USUARIO 03", Email = "email@gmail.com", Perfil = "Administrador", Status = "Ativo" },
                new { Codigo = "4", Nome = "USUARIO 04", Email = "email@gmail.com", Perfil = "Administrador", Status = "Ativo" },           };

            gbUsuarios.SetDataSource(data);
        }
    }
}
