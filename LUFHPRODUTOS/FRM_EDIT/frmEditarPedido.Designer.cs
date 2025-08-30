namespace LUFHPRODUTOS
{
    partial class frmEditarPedido
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtOrdemServico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceito = new System.Windows.Forms.RadioButton();
            this.btnNegado = new System.Windows.Forms.RadioButton();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConcluido = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(79)))), ((int)(((byte)(86)))));
            this.btnVoltar.Location = new System.Drawing.Point(151, 396);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(207, 49);
            this.btnVoltar.TabIndex = 48;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip,
            this.Mensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(549, 26);
            this.statusStrip1.TabIndex = 47;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(82, 20);
            this.statusStrip.Text = "Mensagem";
            // 
            // Mensagem
            // 
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(18, 20);
            this.Mensagem.Text = "...";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(21, 218);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(201, 22);
            this.txtObservacao.TabIndex = 50;
            // 
            // txtOrdemServico
            // 
            this.txtOrdemServico.Location = new System.Drawing.Point(308, 130);
            this.txtOrdemServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrdemServico.Name = "txtOrdemServico";
            this.txtOrdemServico.Size = new System.Drawing.Size(203, 22);
            this.txtOrdemServico.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Solicitante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ordem de Serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tipo de Serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Observação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Produto";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(279, 321);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(233, 53);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Status";
            // 
            // btnAceito
            // 
            this.btnAceito.AutoSize = true;
            this.btnAceito.Location = new System.Drawing.Point(308, 220);
            this.btnAceito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceito.Name = "btnAceito";
            this.btnAceito.Size = new System.Drawing.Size(66, 20);
            this.btnAceito.TabIndex = 55;
            this.btnAceito.TabStop = true;
            this.btnAceito.Text = "Aceito";
            this.btnAceito.UseVisualStyleBackColor = true;
            // 
            // btnNegado
            // 
            this.btnNegado.AutoSize = true;
            this.btnNegado.Location = new System.Drawing.Point(428, 220);
            this.btnNegado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNegado.Name = "btnNegado";
            this.btnNegado.Size = new System.Drawing.Size(78, 20);
            this.btnNegado.TabIndex = 56;
            this.btnNegado.TabStop = true;
            this.btnNegado.Text = "Negado";
            this.btnNegado.UseVisualStyleBackColor = true;
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.BackColor = System.Drawing.SystemColors.Control;
            this.txtSolicitante.Location = new System.Drawing.Point(21, 49);
            this.txtSolicitante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.ReadOnly = true;
            this.txtSolicitante.Size = new System.Drawing.Size(201, 22);
            this.txtSolicitante.TabIndex = 57;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProduto.Location = new System.Drawing.Point(21, 130);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(201, 22);
            this.txtProduto.TabIndex = 58;
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.BackColor = System.Drawing.SystemColors.Control;
            this.txtTipoServico.Location = new System.Drawing.Point(309, 49);
            this.txtTipoServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.ReadOnly = true;
            this.txtTipoServico.Size = new System.Drawing.Size(201, 22);
            this.txtTipoServico.TabIndex = 59;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(20, 321);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(207, 53);
            this.btnExcluir.TabIndex = 60;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConcluido
            // 
            this.btnConcluido.AutoSize = true;
            this.btnConcluido.Location = new System.Drawing.Point(308, 249);
            this.btnConcluido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConcluido.Name = "btnConcluido";
            this.btnConcluido.Size = new System.Drawing.Size(88, 20);
            this.btnConcluido.TabIndex = 61;
            this.btnConcluido.TabStop = true;
            this.btnConcluido.Text = "Concluido";
            this.btnConcluido.UseVisualStyleBackColor = true;
            // 
            // frmEditarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 503);
            this.Controls.Add(this.btnConcluido);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtTipoServico);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.btnNegado);
            this.Controls.Add(this.btnAceito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtOrdemServico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmEditarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar pedido";
            this.Load += new System.EventHandler(this.frmEditarPedido_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Mensagem;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtOrdemServico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnAceito;
        private System.Windows.Forms.RadioButton btnNegado;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtTipoServico;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RadioButton btnConcluido;
    }
}