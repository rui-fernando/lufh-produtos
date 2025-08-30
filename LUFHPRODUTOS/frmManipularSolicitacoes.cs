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
using WcfService1;

namespace LUFHPRODUTOS
{
    public partial class frmManipularSolicitacoes : Form
    {
        EquipeLabService serviceE = new EquipeLabService();
        SolicitacaoService serviceS = new SolicitacaoService();
        public frmManipularSolicitacoes()
        {
            InitializeComponent();
            CarregarCargos();
            IniciarForm();
        }

        public void IniciarForm()
        {
            var lista = serviceS.listar();
            
            if (lista == null)
            {
                MessageBox.Show("Não existem solicitações cadastradas");
            }
            else
            {
                char letraAnterior = '#';
                int numTabela = -1;
                DataGridView data = new DataGridView();

                foreach (var dado in lista)
                {
                    char primeiraLetra = dado.Nome.Trim()[0];
                    if (primeiraLetra.ToString().ToUpper() == letraAnterior.ToString().ToUpper())
                    {
                        GerarLinha(data, dado);
                    }
                    else
                    {
                        numTabela = numTabela + 1;
                        tc.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        tc.TabPages[numTabela].Controls.Add(dg);
                        GerarTabela(dg);
                        GerarLinha(dg, dado);
                    }

                    letraAnterior = primeiraLetra;
                }

            }
        }

        private void GerarLinha(DataGridView data, Solicitacoes dado)
        {
            int linhaAtual = data.Rows.Add();
            data.Rows[linhaAtual].Cells["Id"].Value = dado.Id;
            data.Rows[linhaAtual].Cells["Nome"].Value = dado.Nome;
            data.Rows[linhaAtual].Cells["Email"].Value = dado.Email;
            data.Rows[linhaAtual].Cells["Celular"].Value = dado.Celular;
            data.Rows[linhaAtual].Cells["CPF"].Value = dado.CPF;
            //depois olhar o celular e cpf
        }

        private void GerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dg.Dock = DockStyle.Fill;
            dg.RowHeadersVisible = false;
            dg.BackgroundColor = Color.White;
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dg.DefaultCellStyle.SelectionForeColor = Color.White;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;


            dg.Columns.Clear(); // Remove quaisquer colunas antigas para evitar duplicação
            dg.Columns.Add("Id", "ID");
            dg.Columns.Add("Nome", "Nome");
            dg.Columns.Add("Email", "E-mail");
            dg.Columns.Add("Celular", "Celular");
            dg.Columns.Add("CPF", "CPF");

            dg.CellClick += new DataGridViewCellEventHandler(this.tb_click);

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

        private EquipeLab objGerado(Solicitacoes soli)
        {
            EquipeLab obj = new EquipeLab
            {
                Id = soli.Id,
                Nome = soli.Nome,
                Celular = soli.Celular,
                Email = soli.Email,
                Senha = soli.Senha,
                CPF = soli.CPF,
                Salt = soli.Salt,
                Cargo = cbCargo.SelectedValue as string ?? "Não definido"
            };

            return obj;
        }

        private string ValidarCad()
        {
            if (string.IsNullOrEmpty(cbCargo.SelectedValue as string))
            {
                return "Selecione um cargo para o funcionário.";
            }
            else
            {
                return "Sucesso";
            }
        }

        private void btnAceitar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    EquipeLab funcionario = new EquipeLab();
                    Solicitacoes solicitacao = new Solicitacoes();

                    solicitacao = serviceS.buscar(Convert.ToInt64(tbID.Text));
                    funcionario = objGerado(solicitacao);
                    serviceS.modificarStatus(solicitacao.Id, true);
                    funcionario.Matricula = serviceE.gerarMatricula(funcionario);
                    funcionario.IdFuncionarioCriador = UsuarioAtual.UsuarioId;
                    funcionario.StatusEquipe = "Cadastrado";
                    serviceE.Cadastrar(funcionario);

                    MessageBox.Show("Cadastro efetuado com sucesso");
                    this.Close();
                    var frm = new frmVisualizarEquipe();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar" + ex.Message);
            }
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            try
            {
                Mensagem.Text = ValidarCad();
                if (Mensagem.Text == "Sucesso")
                {
                    Solicitacoes solicitacao = new Solicitacoes();
                    solicitacao = serviceS.buscar(Convert.ToInt64(tbID.Text));
                    solicitacao.IdFuncionarioEditor = UsuarioAtual.UsuarioId;

                    serviceS.modificarStatus(solicitacao.Id, false);

                    MessageBox.Show("Funcionario negado com sucesso");
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar" + ex.Message);
            }
        }


        private void tb_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            try
            {
                if (e.RowIndex != -1)
                {
                    var id = dg.Rows[e.RowIndex].Cells[0].Value;
                    Solicitacoes obj = serviceS.buscar(Convert.ToInt64(id));
                    tbNome.Text = obj.Nome;
                    tbEmail.Text = obj.Email;
                    mtbCelular.Text = obj.Celular;
                    mtbCPF.Text = obj.CPF;
                    tbID.Text = Convert.ToString(obj.Id);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao preencher os campos com os dados da solicitação selecionada " + ex.Message);
            }
        }

        private void frmManipularSolicitacoes_Load(object sender, EventArgs e)
        {

        }
    }
}
