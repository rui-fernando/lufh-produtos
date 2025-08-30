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
    public partial class frmVisualizarServicos : Form
    {
        ServicoService serviceServ = new ServicoService();
        TipoServicoService serviceTS = new TipoServicoService();
        EquipeLabService serviceE = new EquipeLabService();

        public frmVisualizarServicos()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            var lista = serviceServ.listar();

            if (lista == null || !lista.Any())
            {
                MessageBox.Show("Não existem pedidos cadastrados");
                return;
            }

            var servicosAgrupados = lista.GroupBy(p => p.StatusServico);

            foreach (var grupo in servicosAgrupados)
            {

                var tabPage = new TabPage(grupo.Key);
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
                foreach (var servico in grupo)
                {
                    GerarLinha(dg, servico);
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

            dgv.Columns.Add("IdServico", "IdServico");
            dgv.Columns.Add("IdFuncionarioCriador", "Funcionario_Criador");
            dgv.Columns.Add("IdFuncionarioEditor", "Funcionario_Editor");
            dgv.Columns.Add("Status", "Status");
            dgv.Columns.Add("Detalhes", "Detalhes");
            dgv.Columns.Add("IdTipoServico", "IdTipoServico");
        }
        
        private void GerarLinha(DataGridView data, Servico dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells[0].Value = dado.IdServico;
            data.Rows[linhaAtual].Cells[1].Value = serviceE.Buscar(dado.IdFuncionarioCriador).Nome;
            data.Rows[linhaAtual].Cells[2].Value = serviceE.Buscar(dado.IdFuncionarioEditor)?.Nome ?? "Não editado";
            data.Rows[linhaAtual].Cells[3].Value = dado.StatusServico;
            data.Rows[linhaAtual].Cells[4].Value = dado.DetalhesServico;
            data.Rows[linhaAtual].Cells[5].Value = serviceTS.Buscar(dado.IdTipoServico).NomeTipoServico;

        }

        private void tbClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) // Ignora cliques fora de células válidas
                return;
            try
            {
                var id = dg.Rows[e.RowIndex].Cells[0].Value;
                Servico obj = serviceServ.Buscar(Convert.ToInt64(id));

                var form = new frmEditarServico(obj);

                form.ShowDialog(); // Aguarda o fechamento do formulário de edição

                this.Close();
                frmVisualizarServicos frm = new frmVisualizarServicos();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao preencher os campos com os dados da solicitação selecionada " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
