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
using WcfService1;

namespace LUFHPRODUTOS
{
    public partial class frmEditarSolicitante : Form
    {
        SolicitanteService serviceS = new SolicitanteService();
        Solicitante objAtual = new Solicitante();
        public frmEditarSolicitante(Solicitante obj)
        {
            InitializeComponent();
            objAtual = obj;
            IniciarForm();
        }

        private void IniciarForm()
        {
            txtNome.Text = objAtual.Nome.ToString();
            txtCelular.Text = objAtual.Celular.ToString();
            txtEmail.Text = objAtual.Email.ToString();
            txtCPFCNPJ.Text = objAtual.Documento.ToString();
        }
        private string ValidarCad()
        {

            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo Peso";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo do Tipo";
            }
            else if (txtCPFCNPJ.Text == string.Empty)
            {
                return "Preencha o campo Modelo";
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
                Id = objAtual.Id,
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Celular = Regex.Replace(txtCelular.Text, @"\D", ""),
                Documento = txtCPFCNPJ.Text,
                IdFuncionarioEditor = UsuarioAtual.UsuarioId,
            };

            return obj;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    Solicitante obj = new Solicitante();
                    obj = objGerado();
                    serviceS.Editar(obj);

                    MessageBox.Show("Edição de produto efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarSolicitantes();
                    frm.ShowDialog();

                    this.Close();
                }
                else if (Mensagem.Text != "Sucesso")
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var frm = new frmVisualizarSolicitantes();
            frm.ShowDialog();

            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Solicitante objAux = new Solicitante();

            objAux = objAtual;
            objAux.IdFuncionarioEditor = UsuarioAtual.UsuarioId;
            objAux.StatusSolicitante = "Excluído";

            serviceS.Editar(objAux);

            MessageBox.Show("Exclusão da equipe feita com sucesso.");

            this.Close();
        }
    }
}
