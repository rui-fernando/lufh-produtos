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
    public partial class frmEditarTipoDeServico : Form
    {
        TipoServico obj = new TipoServico();
        TipoServicoService serviceTS = new TipoServicoService();

        public frmEditarTipoDeServico(TipoServico obj)
        {
            InitializeComponent();
            IniciarFormulario(obj);
        }

        private void IniciarFormulario(TipoServico objP)
        {
            this.obj = objP;
            txtNomeTipoServ.Text = this.obj.NomeTipoServico;
            txtDetalhe.Text = this.obj.DetalheTipoServico;

        }

        private TipoServico objGerado()
        {
            TipoServico objAtual = new TipoServico
            {
                IdTipoServico = obj.IdTipoServico,
                DetalheTipoServico = txtDetalhe.Text,
                NomeTipoServico = txtNomeTipoServ.Text,
                IdFuncionarioEditor = UsuarioAtual.UsuarioId,
            };
            return objAtual;
        }

        private string ValidarCad()
        {

            if (txtNomeTipoServ.Text == string.Empty)
            {
                return "Preencha o campo Nome";
            }
            else if (txtDetalhe.Text == string.Empty)
            {
                return "Preencha o campo Detalhe";
            }

            else
            {
                return "Sucesso";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    TipoServico objAtual = new TipoServico();
                    objAtual = objGerado();
                    serviceTS.Editar(objAtual);

                    MessageBox.Show("Edição de produto efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarTipoServico();
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

            var frm = new frmVisualizarTipoServico();
            frm.ShowDialog();

            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            TipoServico objAux = new TipoServico();

            objAux = obj;
            objAux.IdFuncionarioEditor = UsuarioAtual.UsuarioId;
            objAux.StatusTipoServico = "Excluído";

            serviceTS.Editar(objAux);

            MessageBox.Show("Exclusão da equipe feita com sucesso.");

            this.Close();
        }
    }
}
