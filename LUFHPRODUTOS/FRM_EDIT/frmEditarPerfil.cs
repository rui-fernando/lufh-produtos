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
using WcfService;

namespace LUFHPRODUTOS
{
    public partial class frmEditarPerfil : Form
    {
        EquipeLabService serviceE = new EquipeLabService();
        EquipeLab obj = new EquipeLab();
        public frmEditarPerfil(EquipeLab objAtual)
        {
            InitializeComponent();
            obj = objAtual;
            IniciarForm();
        }

        private void IniciarForm()
        {
            txtCPF.Text = obj.CPF;
            txtNome.Text = obj.Nome;
            txtCelular.Text = obj.Celular;
            txtEmail.Text = obj.Email;
        }

        private string ValidarCad()
        {

            if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo Celular";
            }
            else if (txtEmail.Text == string.Empty)
            {
                return "Preencha o campo Email";
            }
            else
            {
                return "Sucesso";
            }
        }


        private EquipeLab objGerado()
        {
            EquipeLab objAux = new EquipeLab
            {
                Id = obj.Id,
                Email = txtEmail.Text,
                Celular = Regex.Replace(txtCelular.Text, @"\D", ""),
            };

            return objAux;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    EquipeLab objAtual = new EquipeLab();
                    objAtual = objGerado();
                    serviceE.Editar(objAtual);

                    MessageBox.Show("Edição de pedido efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarPerfil();
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
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNovaSenha frm = new frmNovaSenha();
            frm.ShowDialog();
        }
    }
}
