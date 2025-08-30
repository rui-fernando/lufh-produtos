using Controllers.util;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;
using WcfService1;

namespace LUFHPRODUTOS
{
    public partial class frmCadastroEquipe : Form
    {
        EquipeLabService service = new EquipeLabService();
        SolicitacaoService serviceSoli = new SolicitacaoService();
        public frmCadastroEquipe()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    Solicitacoes obj = new Solicitacoes();
                    obj = objGerado();
                    serviceSoli.Cadastrar(obj);
                    MessageBox.Show("Cadastro efetuado com sucesso");

                    this.Visible = false;

                    var frmLogin = new frmLogin();
                    frmLogin.ShowDialog();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private Solicitacoes objGerado()
        {
            Solicitacoes obj = new Solicitacoes
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                CPF = Regex.Replace(txtCPF.Text, @"\D", ""),
                Senha = txtSenha.Text,
                Celular = Regex.Replace(txtCelular.Text, @"\D", ""),
                Status = "Pendente"
            };


            return obj;
        }

        private string ValidarCad()
        {

            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo Email";
            }
            else if (txtCPF.Text == string.Empty)
            {
                return "Preencha o campo do CPF";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo Celular";
            }
            else if (txtSenha.Text == string.Empty)
            {
                return "Preencha o campo da Senha";
            }
            else if (txtConfSenha.Text == string.Empty)
            {
                return "Confirme a senha";
            }
            else if (txtConfSenha.Text != txtSenha.Text)
            {
                return "As senhas não estão iguais";
            }
            else
            {
                return "Sucesso";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var frm = new frmLogin();
            frm.ShowDialog();

            this.Close();
        }
    }
}
