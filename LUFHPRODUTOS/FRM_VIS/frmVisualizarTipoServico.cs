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
    public partial class frmVisualizarTipoServico : Form
    {
        TipoServicoService serviceTS = new TipoServicoService();
        EquipeLabService serviceE = new EquipeLabService();

        public frmVisualizarTipoServico()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            var lista = serviceTS.listar();

            if (lista == null || !lista.Any())
            {
                MessageBox.Show("Não existem pedidos cadastrados");
                return;
            }

            var TipoServicosAgrupados = lista.GroupBy(p => p.StatusTipoServico).ToList();

            foreach (var grupo in TipoServicosAgrupados)
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
                foreach (var tipoServico in grupo)
                {
                    GerarLinha(dg, tipoServico);
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

            dgv.Columns.Add("IdTipoServico", "ID_Tipo_De_Servico");
            dgv.Columns.Add("IdFuncionarioCriador", "Funcionario_Criador");
            dgv.Columns.Add("IdFuncionarioEditor", "Funcionario_Editor");
            dgv.Columns.Add("NomeTipoServico", "Nome");
            dgv.Columns.Add("DetalheTipoServico", "Detalhe");
        }

        public void GerarLinha(DataGridView dgv, TipoServico obj)
        {
            int linhaAtual = dgv.Rows.Add();
            dgv.Rows[linhaAtual].Cells[0].Value = obj.IdTipoServico;
            dgv.Rows[linhaAtual].Cells[1].Value = serviceE.Buscar(obj.IdFuncionarioCriador).Nome;
            dgv.Rows[linhaAtual].Cells[2].Value = serviceE.Buscar(obj.IdFuncionarioEditor)?.Nome ?? "Não editado";
            dgv.Rows[linhaAtual].Cells[3].Value = obj.NomeTipoServico;
            dgv.Rows[linhaAtual].Cells[4].Value = obj.DetalheTipoServico;
        }

        private void tbClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;

            if (e.RowIndex < 0 || e.ColumnIndex < 0) // Ignora cliques fora de células válidas
                return;

            try
            {
                var id = dg.Rows[e.RowIndex].Cells[0].Value;
                TipoServico obj = serviceTS.Buscar(Convert.ToInt64(id));

                var form = new frmEditarTipoDeServico(obj);

                form.ShowDialog(); // Aguarda o fechamento do formulário de edição

                this.Close();
                frmVisualizarTipoServico frm = new frmVisualizarTipoServico();
                frm.ShowDialog();

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
