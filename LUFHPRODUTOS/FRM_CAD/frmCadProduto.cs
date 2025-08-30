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
    public partial class frmCadProduto : Form
    {
        //EquipeLabService service = new EquipeLabService();
        ProdutoService serviceProd = new ProdutoService();
        SolicitanteService serviceSoli = new SolicitanteService();
        public frmCadProduto()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            try
            {
                var lista = serviceSoli.listar();
                var listaD = new Dictionary<long, string>
            {
                { 0, "Selecione um Solicitante" }
            };

                foreach (var item in lista)
                {

                    listaD.Add(item.Id, item.Nome);

                }

                cbSolicitante.DataSource = new BindingSource(listaD, null);
                cbSolicitante.DisplayMember = "Value";
                cbSolicitante.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Solicitantes! " + ex.Message);
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
                    Produto obj = new Produto();
                    obj = objGerado();
                    serviceProd.Cadastrar(obj);
                    MessageBox.Show("Cadastro de produto efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarProdutos();
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
            else if (txtPeso.Text == string.Empty)
            {
                return "Preencha o campo Peso";
            }
            else if (txtTipo.Text == string.Empty)
            {
                return "Preencha o campo do Tipo";
            }

            else if (txtModelo.Text == string.Empty)
            {
                return "Preencha o campo Modelo";
            }

            else if (cbSolicitante.Text == string.Empty)
            {
                return "Preencha o campo Solicitante";
            }

            else
            {
                return "Sucesso";
            }
        }


        private Produto objGerado()
        {
            Produto obj = new Produto
            {
                NomeProduto = txtNome.Text,
                PesoProduto = Convert.ToDouble(txtPeso.Text),
                ModeloProduto = txtModelo.Text,
                TipoProduto = txtTipo.Text,
                IdSolicitante = Convert.ToInt64(cbSolicitante.SelectedValue),
                IdFuncionarioCriador = UsuarioAtual.UsuarioId,
                StatusProduto = "Pendente",
            };

            return obj;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
