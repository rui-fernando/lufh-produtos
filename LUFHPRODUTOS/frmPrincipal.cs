using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUFHPRODUTOS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            manipularPaineis(1);
        }

        private void apresentação1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipularPaineis(1);
        }


        private void apresentação2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipularPaineis(2);
        }

        private void manipularPaineis(int i)
        {
            if (i == 1)
            {
                pnlApresentacao1.Visible = true;
                pnlApresentacao2.Visible = false;
                pnlApresentacao1.Dock = DockStyle.Fill;
            }
            else if (i == 2)
            {
                pnlApresentacao1.Visible = false;
                pnlApresentacao2.Visible = true;
                pnlApresentacao2.Dock = DockStyle.Fill;
            }
        }

        /*private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFuncionario frm = new frmCadFuncionario();
            frm.ShowDialog();
        }

        */

        private void solicitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadSolicitante frm = new frmCadSolicitante();
            frm.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProduto frm = new frmCadProduto();
            frm.ShowDialog();

        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadServico frm = new frmCadServico();
            frm.ShowDialog();
        }

        private void tipoDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadTipoDeServico frm = new frmCadTipoDeServico();
            frm.ShowDialog();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadPedido frm = new frmCadPedido();
            frm.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmVisualizarPerfil frm =new frmVisualizarPerfil();
            frm.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarPedidos frm =  new frmVisualizarPedidos();
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarProdutos frm = new frmVisualizarProdutos();
            frm.ShowDialog();
        }

        private void solicitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarSolicitantes frm = new frmVisualizarSolicitantes();
            frm.ShowDialog();
        }

        private void tiposDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarTipoServico frm = new frmVisualizarTipoServico();
            frm.ShowDialog();
        }

        private void serviçoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVisualizarServicos frm = new frmVisualizarServicos();
            frm.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarEquipe frm = new frmVisualizarEquipe();
            frm.ShowDialog();
        }

        private void btnPerfil_Click_1(object sender, EventArgs e)
        {
            frmVisualizarPerfil frm = new frmVisualizarPerfil();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta a tela principal temporariamente
            frmLogin frm = new frmLogin();
            frm.ShowDialog(); // Exibe a tela de login como modal
            this.Close(); // Fecha completamente a tela principal após o login ser fechado
        }
    }
}
