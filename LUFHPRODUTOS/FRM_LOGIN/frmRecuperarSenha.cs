using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WcfService;

namespace LUFHPRODUTOS
{
    public partial class frmRecuperarSenha : Form
    {
        EquipeLabService serviceE = new EquipeLabService();

        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void frmRecuperarSenha_Load(object sender, EventArgs e)
        {
            txtEmail.Text = "Email"; // Placeholder inicial
            txtEmail.ForeColor = System.Drawing.Color.Gray;

            // Evento Enter: limpa o placeholder
            txtEmail.Enter += (s, args) =>
            {
                if (txtEmail.Text == "Email")
                {
                    txtEmail.Text = "";
                    txtEmail.ForeColor = System.Drawing.Color.Black;
                }
            };

            // Evento Leave: restaura o placeholder se necessário
            txtEmail.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    txtEmail.Text = "Email";
                    txtEmail.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            var emailRemetente = new MailAddress("lufhemails@gmail.com", "LUFH");
            const string senhaEmailLufh = "bxzq fvsw yfiy nsjj";
            var emailDestinatario = new MailAddress(txtEmail.Text);

            if (serviceE.emailExist(txtEmail.Text))// aqui vai ficar verificando se o email é valido
            {
                const string assunto = "Redefinição de senha";

                string tokenRecuperarSenha = Guid.NewGuid().ToString();

                string body = $@"
                    Olá,

                    Recebemos uma solicitação para redefinir sua senha. Copie o codigo abaixo e cole no campo para redefinir sua senha:

                                        {tokenRecuperarSenha}
                
                    Lembrete: O tempo maximo são de 15 minutos para a redefinição. Após o tempo, o codigo ficará inutilizavel.                

                    Se você não solicitou essa alteração, por favor, ignore este e-mail.

                    Atenciosamente,
                    [Seu Nome/Equipe]
                ";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",//é passado o servidor que vai ""Gerenciar"" os emails
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailRemetente.Address, senhaEmailLufh)
                    //é passado o email e a senha para que seja gerada a mensagem
                };


                try
                {
                    using (var message = new MailMessage(emailRemetente, emailDestinatario)
                    {
                        Subject = assunto,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }

                    MessageBox.Show("E-mail enviado com sucesso!");

                    this.Visible = false;
                    frmCodRecuperarSenha frm = new frmCodRecuperarSenha(tokenRecuperarSenha);
                    frm.ShowDialog();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao enviar e-mail: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Insira um email valido");
            }
        }
    }
}
