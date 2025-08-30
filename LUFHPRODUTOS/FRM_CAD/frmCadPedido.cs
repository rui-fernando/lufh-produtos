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
    public partial class frmCadPedido : Form
    {
        bool carregou = false;
        PedidoService servicePed = new PedidoService();
        SolicitanteService serviceSoli = new SolicitanteService();
        ProdutoService serviceProdu = new ProdutoService();
        ServicoService serviceServico = new ServicoService();
        TipoServicoService serviceTipoServico = new TipoServicoService();
        public frmCadPedido()
        {
            InitializeComponent();
            IniciarForm();

        }

        private void IniciarForm()
        {
            carregarSolicitante();
            //carregarProdutos();
            carregarTipoServiço();
            carregou = true;
        }

        private void carregarTipoServiço()
        {
            try
            {
                var lista = serviceTipoServico.listar();
                //tipo de serviço ou serviço?
                var listaD = new Dictionary<long, string>
            {
                { 0, "Selecione uma solicitação" }
            };

                foreach (var item in lista)
                {
                    
                        listaD.Add(item.IdTipoServico, item.NomeTipoServico);
                    
                }

                cbServico.DataSource = new BindingSource(listaD, null);
                cbServico.DisplayMember = "Value";
                cbServico.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de solicitações! " + ex.Message);
            }
        }

        private void carregarProdutos()
        {
            try
            {
                var lista = serviceProdu.listarPorSolicitante(Convert.ToInt64(cbSolicitante.SelectedValue));
                //var lista = serviceProdu.listarPorSolicitante(idsolicitante) 
                var listaD = new Dictionary<long, string>
            {
                { 0, "Selecione um produto" }
            };

                foreach (var item in lista)
                {

                    listaD.Add(item.IdProduto, item.NomeProduto);

                }

                cbProduto.DataSource = new BindingSource(listaD, null);
                cbProduto.DisplayMember = "Value";
                cbProduto.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Produtos! " + ex.Message);
            }
        }

        private void carregarSolicitante()
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

                cbSolicitante.SelectedIndex = 0; // Garante que o primeiro item seja selecionado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de Solicitantes! " + ex.Message);
            }
        }

        private void cbSolicitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregou && cbSolicitante.SelectedValue != null)
            {
                carregarProdutos();
            }
        }

        private Pedido objGerado()
        {
            Pedido obj = new Pedido
            {
                StatusPedido = "Pendente",
                IdSolicitante = cbSolicitante.SelectedValue != null && Convert.ToInt64(cbSolicitante.SelectedValue) != 0
                    ? Convert.ToInt64(cbSolicitante.SelectedValue)
                    : throw new Exception("Selecione um solicitante válido."),
                IdProduto = cbProduto.SelectedValue != null && Convert.ToInt64(cbProduto.SelectedValue) != 0
                    ? Convert.ToInt64(cbProduto.SelectedValue)
                    : throw new Exception("Selecione um produto válido."),
                IdTipoServico = cbServico.SelectedValue != null && Convert.ToInt64(cbServico.SelectedValue) != 0
                    ? Convert.ToInt64(cbServico.SelectedValue)
                    : throw new Exception("Selecione um serviço válido."),
                IdFuncionarioCriador = UsuarioAtual.UsuarioId,
                OrdemServico = txtOrdemServico.Text,
                ObservacaoPedido = txtObservacao.Text,
                DataPedido = DateTime.Now,
            };

            return obj;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    Pedido obj = new Pedido();
                    obj = objGerado();
                    servicePed.Cadastrar(obj);
                    MessageBox.Show("Cadastro de pedido efetuado com sucesso");

                    this.Visible = false;

                    frmVisualizarPedidos frm = new frmVisualizarPedidos();
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

            if (txtObservacao.Text == string.Empty)
            {
                return "Preencha o campo Observação";
            }
            else if (cbSolicitante.Text == string.Empty)
            {
                return "Preencha o campo Solicitante";
            }

            else if (cbProduto.Text == string.Empty)
            {
                return "Preencha o campo Produto";
            }

            else if (cbServico.Text == string.Empty)
            {
                return "Preencha o campo da Serviço";
            }
            else if (txtOrdemServico.Text == string.Empty)
            {
                return "Preencha o campo Ordem de Serviço";
            }
            else
            {
                return "Sucesso";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
