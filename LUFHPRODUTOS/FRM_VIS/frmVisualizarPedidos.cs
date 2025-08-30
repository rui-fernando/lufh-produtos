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
using WcfService1;

namespace LUFHPRODUTOS
{
    public partial class frmVisualizarPedidos : Form
    {
        PedidoService servicePe = new PedidoService();
        EquipeLabService serviceE = new EquipeLabService();
        SolicitanteService serviceS = new SolicitanteService();
        ProdutoService servicePr = new ProdutoService();
        TipoServicoService serviceT = new TipoServicoService();

        public frmVisualizarPedidos()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            var lista = servicePe.listar();

            if (lista == null || !lista.Any())
            {
                MessageBox.Show("Não existem pedidos cadastrados");
                return;
            }

            var pedidosAgrupados = lista.GroupBy(p => p.StatusPedido).ToList();

            foreach (var grupo in pedidosAgrupados)
            {
                // Adiciona uma nova aba para o status
                var tabPage = new TabPage(grupo.Key); // Nome da aba será o StatusPedido
                tabControl1.TabPages.Add(tabPage);

                // Cria um DataGridView para essa aba
                DataGridView dg = new DataGridView
                {
                    Dock = DockStyle.Fill // Garante que o DataGridView preencha todo o espaço da aba
                };
                tabPage.Controls.Add(dg); // Adiciona o DataGridView à aba
                GerarTabela(dg);

                // Vincula o evento de clique para manipular edições
                dg.CellClick += tbClick;

                // Preenche os dados na tabela
                foreach (var pedido in grupo)
                {
                    GerarLinha(dg, pedido);
                }
            }
        }

        private void GerarTabela(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Chocolate;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.Columns.Add("IdPedido", "ID_Pedido");
            dgv.Columns.Add("IdFuncionarioCriador", "Funcionario_Criador");
            dgv.Columns.Add("IdFuncionarioEditor", "Funcionario_Editor");
            dgv.Columns.Add("IdSolicitante", "Solicitante");
            dgv.Columns.Add("IdProduto", "Produto");
            dgv.Columns.Add("IdServico", "Tipo_de_Servico");
            dgv.Columns.Add("DataPedido", "Data");
            dgv.Columns.Add("OrdemServico", "Ordem_Servico");
            dgv.Columns.Add("StatusPedido", "Status");
            dgv.Columns.Add("ObservacaoPedido", "Observacao");
        }

        public void GerarLinha(DataGridView dgv, Pedido obj)
        {
            int linhaAtual = dgv.Rows.Add();
            dgv.Rows[linhaAtual].Cells[0].Value = obj.IdPedido;
            dgv.Rows[linhaAtual].Cells[1].Value = serviceE.Buscar(obj.IdFuncionarioCriador).Nome;
            dgv.Rows[linhaAtual].Cells[2].Value = serviceE.Buscar(obj.IdFuncionarioEditor)?.Nome ?? "Não editado";
            dgv.Rows[linhaAtual].Cells[3].Value = serviceS.Buscar(obj.IdSolicitante).Nome;
            dgv.Rows[linhaAtual].Cells[4].Value = servicePr.Buscar(obj.IdProduto).NomeProduto;
            dgv.Rows[linhaAtual].Cells[5].Value = serviceT.Buscar(obj.IdTipoServico).NomeTipoServico;
            dgv.Rows[linhaAtual].Cells[6].Value = obj.DataPedido.ToString("dd/MM/yyyy");
            dgv.Rows[linhaAtual].Cells[7].Value = obj.OrdemServico;
            dgv.Rows[linhaAtual].Cells[8].Value = obj.StatusPedido;
            dgv.Rows[linhaAtual].Cells[9].Value = obj.ObservacaoPedido;
        }

        private void tbClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;

            if (e.RowIndex < 0 || e.ColumnIndex < 0) // Ignora cliques fora de células válidas
                return;

            try
            {
                var id = dg.Rows[e.RowIndex].Cells[0].Value;
                Pedido obj = servicePe.Buscar(Convert.ToInt64(id));

                var form = new frmEditarPedido(obj);

                form.ShowDialog(); // Aguarda o fechamento do formulário de edição
                
                this.Close();
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
