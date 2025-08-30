using Controllers.util;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace LUFHPRODUTOS
{
    public partial class frmLogin : Form
    {
        EquipeLabService service = new EquipeLabService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtCPFMatricula.Text = "CPF/Matricula"; // Placeholder inicial
            txtCPFMatricula.ForeColor = System.Drawing.Color.Gray;

            // Evento Enter: limpa o placeholder
            txtCPFMatricula.Enter += (s, args) =>
            {
                if (txtCPFMatricula.Text == "CPF/Matricula")
                {
                    txtCPFMatricula.Text = "";
                    txtCPFMatricula.ForeColor = System.Drawing.Color.Black;
                }
            };

            // Evento Leave: restaura o placeholder se necessário
            txtCPFMatricula.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtCPFMatricula.Text))
                {
                    txtCPFMatricula.Text = "CPF/Matricula";
                    txtCPFMatricula.ForeColor = System.Drawing.Color.Gray;
                }
            };

            txtSenha.Text = "senha"; // Placeholder inicial
            txtSenha.ForeColor = System.Drawing.Color.Gray;
            txtSenha.PasswordChar = '\0'; // Desabilita o PasswordChar para exibir o placeholder

            // Evento Enter: limpa o placeholder e ativa o PasswordChar
            txtSenha.Enter += (s, args) =>
            {
                if (txtSenha.Text == "senha")
                {
                    txtSenha.Text = "";
                    txtSenha.ForeColor = System.Drawing.Color.Black;
                    txtSenha.PasswordChar = '*'; // Ativa o PasswordChar
                }
            };

            // Evento Leave: restaura o placeholder e desativa o PasswordChar
            txtSenha.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    txtSenha.Text = "senha";
                    txtSenha.ForeColor = System.Drawing.Color.Gray;
                    txtSenha.PasswordChar = '\0'; // Desativa o PasswordChar
                }
            };
        }

        private void btnCriarNovaConta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var frmCadastroEquipe = new frmCadastroEquipe();
            frmCadastroEquipe.ShowDialog();
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            if (ValidarCad())
            {
                MessageBox.Show("Login realizado com sucesso.", "LUFH_Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
                var user = service.BuscarCPF(txtCPFMatricula.Text != "" ? txtCPFMatricula.Text : "");
                UsuarioAtual.UsuarioId = user.Id;
                UsuarioAtual.UsuarioMatricula = user.Matricula;
                var frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
            }
        }

        private bool ValidarCad()
        {
            var user = service.BuscarCPFSenha(txtCPFMatricula.Text != "" ? txtCPFMatricula.Text : "", txtSenha.Text);

            if (user == null || !VerificarAcesso(user))
            {
                MessageBox.Show("Credenciais inválidas" + "\n" + "Por favor, tente novamente.", "LUFH_Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRecuperarSenha frm = new frmRecuperarSenha();
            frm.ShowDialog();
            this.Close();   
        }

        private bool VerificarAcesso(EquipeLab user)
        { 
            if (user.StatusEquipe == "Cadastrado") return true;

            return false;
    
        }
    }
}
