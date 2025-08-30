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
using WcfService;

namespace LUFHPRODUTOS
{
    public partial class frmVisualizarPerfil : Form
    {
        EquipeLabService serviceE = new EquipeLabService();

        EquipeLab obj = new EquipeLab();
        public frmVisualizarPerfil()
        {
            InitializeComponent();
            obj = serviceE.Buscar(UsuarioAtual.UsuarioId);
            IniciarForm();
        }

        private void IniciarForm()
        {
            txtNome.Text = obj.Nome;
            txtEmail.Text = obj.Email;
            txtCPF.Text = obj.CPF;
            txtCelular.Text = obj.Celular;
            txtCargo.Text = obj.Cargo;
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            frmEditarPerfil frm = new frmEditarPerfil(obj);
            frm.ShowDialog();

            this.Close();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
