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
    public partial class frmEditarServico : Form
    {
        Servico obj = new Servico();
        ServicoService serviceServ = new ServicoService();
        TipoServicoService serviceTS = new TipoServicoService();
        public frmEditarServico(Servico obj)
        {
            InitializeComponent();
            IniciarFormulario(obj);
        }

        private void IniciarFormulario(Servico objP)
        {
            this.obj = objP;
            txtStatusServico.Text = this.obj.StatusServico;
            txtDetalhes.Text = this.obj.DetalhesServico;
            txtTipoServico.Text = serviceTS.Buscar(this.obj.IdTipoServico).NomeTipoServico;

        }

        private Servico objGerado()
        {
            Servico objAtual = new Servico
            {
                IdServico = obj.IdServico,
                DetalhesServico = txtDetalhes.Text,
                StatusServico = txtStatusServico.Text,
                IdFuncionarioEditor = UsuarioAtual.UsuarioId,
            };

            return objAtual;
        }


        private string ValidarCad()
        {

            if (txtStatusServico.Text == string.Empty)
            {
                return "Preencha o campo Status";
            }
            else if (txtDetalhes.Text == string.Empty)
            {
                return "Preencha o campo Detalhes";
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
                    Servico objAtual = new Servico();
                    objAtual = objGerado();
                    serviceServ.Editar(objAtual);

                    MessageBox.Show("Edição de produto efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarServicos();
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

            var frm = new frmVisualizarServicos();
            frm.ShowDialog();

            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Servico objAux = new Servico();

            objAux = obj;
            objAux.IdFuncionarioEditor = UsuarioAtual.UsuarioId;
            objAux.StatusServico = "Excluído";

            serviceServ.Editar(objAux);

            MessageBox.Show("Exclusão da equipe feita com sucesso.");

            this.Close();
        }
    }
}
