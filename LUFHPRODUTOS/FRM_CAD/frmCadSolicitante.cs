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
    public partial class frmCadSolicitante : Form
    {
        EquipeLabService service = new EquipeLabService();
        //SolicitacaoService serviceSoli = new SolicitacaoService();
        //SolicitanteService serviceSolicitante = new SolicitanteService();
        public frmCadSolicitante()
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
                    Solicitante obj = new Solicitante();
                    obj = objGerado();
                    service.cadastrarSoli(obj);
                    MessageBox.Show("Cadastro de solicitante efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarSolicitantes();
                    frm.ShowDialog();

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

            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo Email";
            }

            else if (txtCelular.Text ==  string.Empty)
            {
                return "Preencha o campo Telefone";
            }
            
            else if (txtCPFCNPJ.Text == string.Empty)
            {
                return "Preencha o campo CPF/CNPJ";
            }
            else
            {
                return "Sucesso";
            }
        }


        private Solicitante objGerado()
        {
            Solicitante obj = new Solicitante
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Celular = Regex.Replace(txtCelular.Text, @"\D", ""),
                Documento = txtCPFCNPJ.Text,
                StatusSolicitante = "Pendente",
                IdFuncionarioCriador = UsuarioAtual.UsuarioId,
            };


            return obj;
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {     
            this.Close();
        }
    }
}
