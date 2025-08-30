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
using WcfService1;

namespace LUFHPRODUTOS
{
    public partial class frmEditarProdutos : Form
    {
        ProdutoService serviceProd = new ProdutoService();
        SolicitanteService serviceSoli = new SolicitanteService();
        Produto objAtual = new Produto();
        public frmEditarProdutos(Produto obj)
        {
            InitializeComponent();
            objAtual = obj;
            IniciarForm();
        }

        private void IniciarForm()
        {
            txtNome.Text = objAtual.NomeProduto.ToString();
            txtModelo.Text = objAtual.ModeloProduto.ToString();
            txtPeso.Text = objAtual.PesoProduto.ToString();
            txtSolicitante.Text = serviceSoli.Buscar(objAtual.IdSolicitante).Nome;
            txtTipo.Text = objAtual.TipoProduto.ToString();
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
            else
            {
                return "Sucesso";
            }
        }


        private Produto objGerado()
        {
            Produto obj = new Produto
            {
                IdProduto = objAtual.IdProduto,
                NomeProduto = txtNome.Text,
                PesoProduto = Convert.ToDouble(txtPeso.Text),
                ModeloProduto = txtModelo.Text,
                TipoProduto = txtTipo.Text,
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
                    Produto obj = new Produto();
                    obj = objGerado();
                    serviceProd.Editar(obj);

                    MessageBox.Show("Edição de produto efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarProdutos();
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

            frmVisualizarProdutos frm = new frmVisualizarProdutos();
            frm.ShowDialog();

            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto objAux = new Produto();

            objAux = objAtual;
            objAux.IdFuncionarioEditor = UsuarioAtual.UsuarioId;
            objAux.StatusProduto = "Excluído";

            serviceProd.Editar(objAux);

            MessageBox.Show("Exclusão da equipe feita com sucesso.");

            this.Close();
        }
    }
}
