using Controllers.util;
using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace LUFHPRODUTOS
{
    public partial class frmVisualizarEquipe : Form
    {
        EquipeLabService equipeLabService = new EquipeLabService();
        public frmVisualizarEquipe()
        {
            InitializeComponent();
            IniciarForm();
        }

        private void IniciarForm()
        {
            if (!VerificarPermissao())
            {
                btnSoliciacoes.Visible = false;
                btnSoliciacoes.Enabled = false;
            }

            var listaT = equipeLabService.Listar("Tecnico");
            var listaE = equipeLabService.Listar("Especialista");
            var listaC = equipeLabService.Listar("Coordenador");
            var listaA = equipeLabService.Listar("Admin");
            var listaEx = equipeLabService.ListarStatus("Excluido");
            if (listaA == null)
            {
                MessageBox.Show("Não existem Admins cadastrados");
            }
            else if (listaC == null)
            {
                MessageBox.Show("Não existem Coordenadores cadastrados");
            }
            else if (listaE == null)
            {
                MessageBox.Show("Não existem Especialistas cadastrados");
            }
            else if (listaT == null)
            {
                MessageBox.Show("Não existem Técnicos cadastrados");
            }
            else if (listaEx == null)
            {
                MessageBox.Show("Não existem funcionarios cancelados");
            }

            for (int i = 0; i < 5; i++) {
           
                DataGridView dg = new DataGridView();
                tcGeral.TabPages[i].Controls.Add(dg);
                GerarTabela(dg);
                if (i == 0)
                {
                    GerarLinha(dg, listaT);
                }
                else if (i == 1)
                {
                    GerarLinha(dg, listaE);
                }
                else if (i == 2)
                {
                    GerarLinha(dg, listaC);
                }
                else if (i == 3)
                {
                    GerarLinha(dg, listaA);
                }
                else
                {
                    GerarLinha(dg, listaEx);
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
            dgv.CellMouseClick += new DataGridViewCellMouseEventHandler(this.Tabela_Clicada);

            dgv.Columns.Add("Id", "ID");
            dgv.Columns.Add("Matricula", "Matricula");
            dgv.Columns.Add("Nome", "Nome");
            dgv.Columns.Add("Email", "E-mail");
            dgv.Columns.Add("StatusEquipe", "Status");
            dgv.Columns.Add("Celular", "Celular");
            dgv.Columns.Add("CPF", "CPF");
        }

        private void Tabela_Clicada(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || !VerificarPermissao()) return; // Evita erro ao clicar no cabeçalho

                DataGridView dgv = sender as DataGridView;

                // Garante que a linha inteira seja selecionada
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Define a linha como selecionada
                dgv.Rows[e.RowIndex].Selected = true;

                // Obtém o ID corretamente
                var idfuncionario = dgv.Rows[e.RowIndex].Cells["Id"].Value;

                if (idfuncionario == null)
                {
                    MessageBox.Show("Erro: ID do funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EquipeLab funcionario = equipeLabService.Buscar(Convert.ToInt32(idfuncionario));

                if (funcionario == null)
                {
                    MessageBox.Show("Erro: Funcionário não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Abre a tela de edição corretamente

                frmEditarEquipe form = new frmEditarEquipe(funcionario);
                form.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro. Favor entrar em contato com o administrador do sistema.\n\nErro: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GerarLinha(DataGridView dgv,List<EquipeLab> lista)
        {
            
            foreach (var obj in lista)
            {
                int linhaAtual = dgv.Rows.Add();
                dgv.Rows[linhaAtual].Cells[0].Value = obj.Id;
                dgv.Rows[linhaAtual].Cells[1].Value = obj.Matricula;
                dgv.Rows[linhaAtual].Cells[2].Value = obj.Nome;
                dgv.Rows[linhaAtual].Cells[3].Value = obj.Email;
                dgv.Rows[linhaAtual].Cells[4].Value = obj.StatusEquipe;
                dgv.Rows[linhaAtual].Cells[5].Value = obj.Celular;
                dgv.Rows[linhaAtual].Cells[6].Value = obj.CPF;
            }
        }

        private bool VerificarPermissao()
        {
            if (UsuarioAtual.UsuarioMatricula.StartsWith("001") || UsuarioAtual.UsuarioMatricula.StartsWith("002")) return true;
            return false;
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSoliciacoes_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            frmManipularSolicitacoes frm = new frmManipularSolicitacoes();
            frm.ShowDialog();

            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
