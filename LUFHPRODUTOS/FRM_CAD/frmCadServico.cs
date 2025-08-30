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
    public partial class frmCadServico : Form
    {
        ServicoService serviceServ = new ServicoService();
        TipoServicoService TServicoService = new TipoServicoService();
        public frmCadServico()
        {
            InitializeComponent();
            iniciarForm();
        }

        private void iniciarForm()
        {
            try
            {
                var lista = TServicoService.listar();
                var listaD = new Dictionary<long, string>
            {
                { 0, "Selecione uma solicitação" }
            };

                foreach (var item in lista)
                {
                    listaD.Add(item.IdTipoServico, item.NomeTipoServico);
                }

                cbTipoServico.DataSource = new BindingSource(listaD, null);
                cbTipoServico.DisplayMember = "Value";
                cbTipoServico.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de solicitações! " + ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    Servico obj = new Servico();
                    obj = objGerado();
                    serviceServ.Cadastrar(obj);
                    MessageBox.Show("Cadastro de serviço efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarServicos();
                    frm.ShowDialog();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private Servico objGerado()
        {
            if (cbTipoServico.SelectedValue != null)
            {
                Servico obj = new Servico
                {
                    StatusServico = "Pendente",
                    DetalhesServico = txtDetalhes.Text,
                    IdTipoServico = (long)cbTipoServico.SelectedValue,
                    IdFuncionarioCriador = UsuarioAtual.UsuarioId,
                };
                return obj;
            }
            return null;
        }

        private string ValidarCad()
        {

            if (txtStatusServico.Text == string.Empty)
            {
                return "Preencha o campo Status";
            }
            else if (txtDetalhes.Text == string.Empty)
            {
                return "Preencha o campo Detalhes";
            }
            else if ((long)cbTipoServico.SelectedValue == 0)
            {
                return "Por favor, selecione uma solicitação válida!";
            }
            else
            {
                return "Sucesso";
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
