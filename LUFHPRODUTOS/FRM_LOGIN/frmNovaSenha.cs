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
    public partial class frmNovaSenha : Form
    {
        EquipeLabService serviceE = new EquipeLabService();
        public frmNovaSenha()
        {
            InitializeComponent();
        }

        private void frmNovaSenha_Load(object sender, EventArgs e)
        {
            // Configuração inicial para txtNovaSenha
            txtNovaSenha.Text = "Nova Senha"; // Placeholder inicial
            txtNovaSenha.ForeColor = System.Drawing.Color.Gray;
            txtNovaSenha.PasswordChar = '\0'; // Desabilita o PasswordChar para exibir o placeholder

            // Configuração inicial para txtNovaSenhaConf
            txtConfNovaSenha.Text = "Confirmar Senha"; // Placeholder inicial
            txtConfNovaSenha.ForeColor = System.Drawing.Color.Gray;
            txtConfNovaSenha.PasswordChar = '\0'; // Desabilita o PasswordChar para exibir o placeholder

            // Eventos para txtNovaSenha
            txtNovaSenha.Enter += (s, args) =>
            {
                if (txtNovaSenha.Text == "Nova Senha")
                {
                    txtNovaSenha.Text = "";
                    txtNovaSenha.ForeColor = System.Drawing.Color.Black;
                    txtNovaSenha.PasswordChar = '*'; // Ativa o PasswordChar
                }
            };

            txtNovaSenha.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtNovaSenha.Text))
                {
                    txtNovaSenha.Text = "Nova Senha";
                    txtNovaSenha.ForeColor = System.Drawing.Color.Gray;
                    txtNovaSenha.PasswordChar = '\0'; // Desativa o PasswordChar
                }
            };

            // Eventos para txtNovaSenhaConf
            txtConfNovaSenha.Enter += (s, args) =>
            {
                if (txtConfNovaSenha.Text == "Confirmar Senha")
                {
                    txtConfNovaSenha.Text = "";
                    txtConfNovaSenha.ForeColor = System.Drawing.Color.Black;
                    txtConfNovaSenha.PasswordChar = '*'; // Ativa o PasswordChar
                }
            };

            txtConfNovaSenha.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtConfNovaSenha.Text))
                {
                    txtConfNovaSenha.Text = "Confirmar Senha";
                    txtConfNovaSenha.ForeColor = System.Drawing.Color.Gray;
                    txtConfNovaSenha.PasswordChar = '\0'; // Desativa o PasswordChar
                }
            };
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    EquipeLab obj = new EquipeLab();

                    obj.Id = UsuarioAtual.UsuarioId;
                    obj.Senha = txtNovaSenha.Text;

                    serviceE.EditarSenha(obj);

                    this.Visible = false;

                    if (UsuarioAtual.UsuarioMatricula == null) //Se matricula for nula significa quenão tem ninguem logado
                    {
                        var frm = new frmLogin();
                        frm.ShowDialog();
                    }

                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }

        }

        private string ValidarCad()
        {

            if (txtNovaSenha.Text == string.Empty)
            {
                return "Preencha o campo nova senha";
            }
            else if (txtConfNovaSenha.Text == string.Empty)
            {
                return "Confirme a confirmar senha";
            }
            else if (txtNovaSenha.Text != txtConfNovaSenha.Text)
            {
                return "As senhas não estão iguais";
            }
            else
            {
                return "Sucesso";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
