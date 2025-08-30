namespace LUFHPRODUTOS
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCPFMatricula = new System.Windows.Forms.TextBox();
            this.btnEsqueceuSenha = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCriarNovaConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSenha.Location = new System.Drawing.Point(119, 198);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(255, 37);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "Senha";
            // 
            // txtCPFMatricula
            // 
            this.txtCPFMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPFMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFMatricula.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCPFMatricula.Location = new System.Drawing.Point(119, 117);
            this.txtCPFMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCPFMatricula.Name = "txtCPFMatricula";
            this.txtCPFMatricula.Size = new System.Drawing.Size(255, 37);
            this.txtCPFMatricula.TabIndex = 6;
            this.txtCPFMatricula.Text = "CPF/Matricula";
            // 
            // btnEsqueceuSenha
            // 
            this.btnEsqueceuSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnEsqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsqueceuSenha.FlatAppearance.BorderSize = 0;
            this.btnEsqueceuSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueceuSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueceuSenha.Location = new System.Drawing.Point(208, 244);
            this.btnEsqueceuSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            this.btnEsqueceuSenha.Size = new System.Drawing.Size(185, 28);
            this.btnEsqueceuSenha.TabIndex = 7;
            this.btnEsqueceuSenha.Text = "Esqueceu a senha?";
            this.btnEsqueceuSenha.UseVisualStyleBackColor = false;
            this.btnEsqueceuSenha.Click += new System.EventHandler(this.btnEsqueceuSenha_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(119, 288);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(256, 49);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 395);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 1);
            this.panel1.TabIndex = 9;
            // 
            // btnCriarNovaConta
            // 
            this.btnCriarNovaConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.btnCriarNovaConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarNovaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarNovaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarNovaConta.ForeColor = System.Drawing.Color.White;
            this.btnCriarNovaConta.Location = new System.Drawing.Point(145, 423);
            this.btnCriarNovaConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarNovaConta.Name = "btnCriarNovaConta";
            this.btnCriarNovaConta.Size = new System.Drawing.Size(207, 39);
            this.btnCriarNovaConta.TabIndex = 10;
            this.btnCriarNovaConta.Text = "Criar nova conta";
            this.btnCriarNovaConta.UseVisualStyleBackColor = false;
            this.btnCriarNovaConta.Click += new System.EventHandler(this.btnCriarNovaConta_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 518);
            this.Controls.Add(this.btnCriarNovaConta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnEsqueceuSenha);
            this.Controls.Add(this.txtCPFMatricula);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCPFMatricula;
        private System.Windows.Forms.Button btnEsqueceuSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCriarNovaConta;
    }
}