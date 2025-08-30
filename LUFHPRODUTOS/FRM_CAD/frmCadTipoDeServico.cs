using Controllers.util;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class frmCadTipoDeServico : Form
    {
        TipoServicoService serviceTipoServ = new TipoServicoService();  

        public frmCadTipoDeServico()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    TipoServico obj = new TipoServico();
                    obj = objGerado();
                    serviceTipoServ.Cadastrar(obj);
                    MessageBox.Show("Cadastro de tipo de serviço efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarTipoServico();
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


        private TipoServico objGerado()
        {
            TipoServico obj = new TipoServico
            {
                NomeTipoServico = txtNomeTipoServ.Text,
                DetalheTipoServico = txtDetalhe.Text,
                IdFuncionarioCriador = UsuarioAtual.UsuarioId,
                StatusTipoServico = "Pendente",
            };


            return obj;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
