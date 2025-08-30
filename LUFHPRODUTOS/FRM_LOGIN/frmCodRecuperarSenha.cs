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
    public partial class frmCodRecuperarSenha : Form
    {
        string token;

        private Timer timer;
        private int segundosRestantes = 300;
        public frmCodRecuperarSenha(string token)
        {
            InitializeComponent();

            // Configura o timer para 1 segundo
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();

            this.token = token;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            segundosRestantes--;

            if (segundosRestantes <= 0)
            {
                timer.Stop();
                MessageBox.Show("O tempo para digitar o código acabou!");

                this.Visible = false;
                var frm = new frmLogin();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                AtualizarTextoLabel();
            }
        }

        private void AtualizarTextoLabel()
        {
            int minutos = segundosRestantes / 60;
            int segundos = segundosRestantes % 60;

            labelTimer.Text = $"Tempo restante: {minutos:D2}:{segundos:D2}";
        }

        private void frmCodRecuperarSenha_Load(object sender, EventArgs e)
        {
            txtCodRecuperação.Text = "Insira o código"; // Placeholder inicial
            txtCodRecuperação.ForeColor = System.Drawing.Color.Gray;


            // Evento Enter: limpa o placeholder e ativa o PasswordChar
            txtCodRecuperação.Enter += (s, args) =>
            {
                if (txtCodRecuperação.Text == "Insira o código")
                {
                    txtCodRecuperação.Text = "";
                    txtCodRecuperação.ForeColor = System.Drawing.Color.Black;

                }
            };

            // Evento Leave: restaura o placeholder e desativa o PasswordChar
            txtCodRecuperação.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtCodRecuperação.Text))
                {
                    txtCodRecuperação.Text = "Insira o código";
                    txtCodRecuperação.ForeColor = System.Drawing.Color.Gray;

                }
            };
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if(txtCodRecuperação.Text != token)
            {
                MessageBox.Show("Codigo Incorreto, por favor verifique");
            }
            else
            {
                frmNovaSenha frm = new frmNovaSenha();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
