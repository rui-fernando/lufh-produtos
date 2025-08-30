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
    public partial class frmEditarPedido : Form
    {
        PedidoService servicePed = new PedidoService();
        SolicitanteService serviceSoli = new SolicitanteService();
        ProdutoService serviceProdu = new ProdutoService();
        TipoServicoService serviceTS = new TipoServicoService();
        TipoServicoService serviceTipoServico = new TipoServicoService();
        Pedido objAtual = new Pedido();
        public frmEditarPedido(Pedido pedidoObj)
        {
            InitializeComponent();
            objAtual = pedidoObj;
            IniciarForm();

        }

        private void IniciarForm()
        {
            preencherCampos(objAtual);
        }

        private void preencherCampos(Pedido pedido)
        {
            try
            {
                if (pedido == null) throw new Exception("Pedido inválido.");

                // Define os valores nos controles com base no objeto
                txtSolicitante.Text = serviceSoli.Buscar(pedido.IdSolicitante).Nome;
                txtProduto.Text = serviceProdu.Buscar(pedido.IdProduto).NomeProduto;
                txtTipoServico.Text = serviceTS.Buscar(pedido.IdTipoServico).NomeTipoServico;
                txtOrdemServico.Text = pedido.OrdemServico;
                txtObservacao.Text = pedido.ObservacaoPedido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher os campos: " + ex.Message);
            }
        }

        private Pedido objGerado()
        {
            Pedido obj = new Pedido
            {
                IdPedido = objAtual.IdPedido,
                StatusPedido = btnAceito.Checked ? "Aceito" : btnConcluido.Checked ? "Concluido" : "Negado",
                IdFuncionarioEditor = UsuarioAtual.UsuarioId,
                OrdemServico = txtOrdemServico.Text,
                ObservacaoPedido = txtObservacao.Text,
            };

            return obj;
        }   

        private string ValidarCad()
        {

            if (txtObservacao.Text == string.Empty)
            {
                return "Preencha o campo Observação";
            }
            else if (txtOrdemServico.Text == string.Empty)
            {
                return "Preencha o campo Ordem de Serviço";
            }
            else if (!btnAceito.Checked && !btnNegado.Checked && !btnConcluido.Checked)
            {
                return "Preencha o campo Status";
            }
            else
            {
                return "Sucesso";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var frm = new frmVisualizarPedidos();
            frm.ShowDialog();

            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Pedido objAux = new Pedido();

            objAux = objAtual;

            objAux.IdFuncionarioEditor = UsuarioAtual.UsuarioId;
            objAux.StatusPedido = "Excluido";

            servicePed.Editar(objAux);

            MessageBox.Show("Exclusão de pedido efetuado com sucesso");

            this.Visible = false;

            var frm = new frmVisualizarPedidos();
            frm.ShowDialog();

            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    Pedido obj = new Pedido();
                    obj = objGerado();
                    servicePed.Editar(obj);

                    MessageBox.Show("Edição de pedido efetuado com sucesso");
                    this.Visible = false;

                    var frm = new frmVisualizarPedidos();
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

        private void frmEditarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
