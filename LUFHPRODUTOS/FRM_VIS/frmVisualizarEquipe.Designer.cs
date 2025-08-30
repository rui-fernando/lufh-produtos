namespace LUFHPRODUTOS
{
    partial class frmVisualizarEquipe
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
            this.tcGeral = new System.Windows.Forms.TabControl();
            this.tpTecnico = new System.Windows.Forms.TabPage();
            this.tpEspecialista = new System.Windows.Forms.TabPage();
            this.tpCoordenador = new System.Windows.Forms.TabPage();
            this.tpAdimin = new System.Windows.Forms.TabPage();
            this.tbCancelados = new System.Windows.Forms.TabPage();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnSoliciacoes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tcGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcGeral
            // 
            this.tcGeral.Controls.Add(this.tpTecnico);
            this.tcGeral.Controls.Add(this.tpEspecialista);
            this.tcGeral.Controls.Add(this.tpCoordenador);
            this.tcGeral.Controls.Add(this.tpAdimin);
            this.tcGeral.Controls.Add(this.tbCancelados);
            this.tcGeral.Location = new System.Drawing.Point(12, 67);
            this.tcGeral.Name = "tcGeral";
            this.tcGeral.SelectedIndex = 0;
            this.tcGeral.Size = new System.Drawing.Size(776, 371);
            this.tcGeral.TabIndex = 0;
            // 
            // tpTecnico
            // 
            this.tpTecnico.Location = new System.Drawing.Point(4, 22);
            this.tpTecnico.Name = "tpTecnico";
            this.tpTecnico.Padding = new System.Windows.Forms.Padding(3);
            this.tpTecnico.Size = new System.Drawing.Size(768, 345);
            this.tpTecnico.TabIndex = 0;
            this.tpTecnico.Text = "Técnicos";
            this.tpTecnico.UseVisualStyleBackColor = true;
            this.tpTecnico.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tpEspecialista
            // 
            this.tpEspecialista.Location = new System.Drawing.Point(4, 22);
            this.tpEspecialista.Name = "tpEspecialista";
            this.tpEspecialista.Padding = new System.Windows.Forms.Padding(3);
            this.tpEspecialista.Size = new System.Drawing.Size(768, 345);
            this.tpEspecialista.TabIndex = 1;
            this.tpEspecialista.Text = "Especialistas";
            this.tpEspecialista.UseVisualStyleBackColor = true;
            // 
            // tpCoordenador
            // 
            this.tpCoordenador.Location = new System.Drawing.Point(4, 22);
            this.tpCoordenador.Name = "tpCoordenador";
            this.tpCoordenador.Padding = new System.Windows.Forms.Padding(3);
            this.tpCoordenador.Size = new System.Drawing.Size(768, 345);
            this.tpCoordenador.TabIndex = 2;
            this.tpCoordenador.Text = "Coordenadores";
            this.tpCoordenador.UseVisualStyleBackColor = true;
            // 
            // tpAdimin
            // 
            this.tpAdimin.Location = new System.Drawing.Point(4, 22);
            this.tpAdimin.Name = "tpAdimin";
            this.tpAdimin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdimin.Size = new System.Drawing.Size(768, 345);
            this.tpAdimin.TabIndex = 3;
            this.tpAdimin.Text = "Administradores";
            this.tpAdimin.UseVisualStyleBackColor = true;
            // 
            // tbCancelados
            // 
            this.tbCancelados.Location = new System.Drawing.Point(4, 22);
            this.tbCancelados.Name = "tbCancelados";
            this.tbCancelados.Padding = new System.Windows.Forms.Padding(3);
            this.tbCancelados.Size = new System.Drawing.Size(768, 345);
            this.tbCancelados.TabIndex = 4;
            this.tbCancelados.Text = "Excluidos";
            this.tbCancelados.UseVisualStyleBackColor = true;
            // 
            // btnSoliciacoes
            // 
            this.btnSoliciacoes.Location = new System.Drawing.Point(606, 38);
            this.btnSoliciacoes.Name = "btnSoliciacoes";
            this.btnSoliciacoes.Size = new System.Drawing.Size(86, 23);
            this.btnSoliciacoes.TabIndex = 2;
            this.btnSoliciacoes.Text = "Solicitações";
            this.btnSoliciacoes.UseVisualStyleBackColor = true;
            this.btnSoliciacoes.Click += new System.EventHandler(this.btnSoliciacoes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Equipe Cadastrada";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(698, 38);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmVisualizarEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSoliciacoes);
            this.Controls.Add(this.tcGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVisualizarEquipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar equipe";
            this.tcGeral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcGeral;
        private System.Windows.Forms.TabPage tpTecnico;
        private System.Windows.Forms.TabPage tpEspecialista;
        private System.Windows.Forms.TabPage tpCoordenador;
        private System.Windows.Forms.TabPage tpAdimin;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnSoliciacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbCancelados;
        private System.Windows.Forms.Button btnVoltar;
    }
}