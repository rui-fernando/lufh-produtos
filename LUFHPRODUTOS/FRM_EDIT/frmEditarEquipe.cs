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
    public partial class frmEditarEquipe : Form
    {
        EquipeLab obj = new EquipeLab();
        EquipeLabService serviceE = new EquipeLabService();
        public frmEditarEquipe(EquipeLab objAtual)
        {
            InitializeComponent();
            obj = objAtual;
            CarregarCargos();
            IniciarForm();
        }

        private void IniciarForm()
        {
            try
            {
                if (obj == null) throw new Exception("Pedido inválido.");

                // Define os valores nos controles com base no objeto
                txtNome.Text = obj.Nome;
                txtEmail.Text = obj.Email;
                txtCPF.Text = obj.CPF;
                txtCelular.Text = obj.Celular;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao preencher os campos: " + ex.Message);
            }
        }

        private void frmEditarEquipe_Load(object sender, EventArgs e)
        {

        }

        private EquipeLab objGerado()
        {
            EquipeLab objAtual = new EquipeLab
            {
                Id = obj.Id,
                Cargo = cbCargo.SelectedValue as string ?? "Não definido",

            };

            return objAtual;
        }

        private string ValidarCad()
        {

            if (cbCargo.SelectedIndex == -1 || cbCargo.SelectedIndex == 0)
            {
                return "Selecione um cargo";
            }
            else
            {
                return "Sucesso";
            }
        }

        private void CarregarCargos()
        {
            try
            {
                var listaCargos = new Dictionary<string, string>
                {
                    { "0", "Selecione um cargo" },
                    { "Admin", "Admin" },
                    { "Coordenador", "Coordenador" },
                    { "Especialista", "Especialista" },
                    { "Tecnico", "Técnico" }
                 };

                cbCargo.DataSource = new BindingSource(listaCargos, null);
                cbCargo.DisplayMember = "Value";
                cbCargo.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a lista de cargos! " + ex.Message);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Mensagem.Text = "";
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    EquipeLab obj = new EquipeLab();
                    obj = objGerado();
                    obj.Matricula = serviceE.gerarMatricula(obj);
                    obj.IdFuncionarioEditor = UsuarioAtual.UsuarioId;
                    serviceE.EditarFuncionario(obj);

                    MessageBox.Show("Edição de funcionario efetuado com sucesso");

                    this.Visible = false;

                    var frm = new frmVisualizarEquipe();
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

            var frm = new frmVisualizarEquipe();
            frm.ShowDialog();

            this.Close();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            EquipeLab objAux = new EquipeLab();

            objAux = obj;
            objAux.IdFuncionarioEditor = UsuarioAtual.UsuarioId;
            objAux.StatusEquipe = "Excluido";

            serviceE.EditarFuncionario(objAux);

            MessageBox.Show("Exclusão da equipe feita com sucesso.");

            this.Close();
        }
    }
}
