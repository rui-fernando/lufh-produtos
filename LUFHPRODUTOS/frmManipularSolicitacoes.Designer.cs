namespace LUFHPRODUTOS
{
    partial class frmManipularSolicitacoes
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
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnNegar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.tc = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(638, 234);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(156, 21);
            this.cbCargo.TabIndex = 1;
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(603, 315);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 23);
            this.btnAceitar.TabIndex = 2;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip,
            this.Mensagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(66, 17);
            this.statusStrip.Text = "Mensagem";
            // 
            // Mensagem
            // 
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(16, 17);
            this.Mensagem.Text = "...";
            // 
            // btnNegar
            // 
            this.btnNegar.Location = new System.Drawing.Point(719, 315);
            this.btnNegar.Name = "btnNegar";
            this.btnNegar.Size = new System.Drawing.Size(75, 23);
            this.btnNegar.TabIndex = 16;
            this.btnNegar.Text = "Negar";
            this.btnNegar.UseVisualStyleBackColor = true;
            this.btnNegar.Click += new System.EventHandler(this.btnNegar_Click);
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.SystemColors.Control;
            this.tbNome.Location = new System.Drawing.Point(410, 78);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(156, 20);
            this.tbNome.TabIndex = 17;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmail.Location = new System.Drawing.Point(638, 78);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(156, 20);
            this.tbEmail.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(635, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(407, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(407, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(635, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(635, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cargo";
            // 
            // mtbCPF
            // 
            this.mtbCPF.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCPF.Location = new System.Drawing.Point(638, 155);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.ReadOnly = true;
            this.mtbCPF.Size = new System.Drawing.Size(156, 20);
            this.mtbCPF.TabIndex = 27;
            // 
            // mtbCelular
            // 
            this.mtbCelular.BackColor = System.Drawing.SystemColors.Control;
            this.mtbCelular.Location = new System.Drawing.Point(410, 155);
            this.mtbCelular.Mask = "(00) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.ReadOnly = true;
            this.mtbCelular.Size = new System.Drawing.Size(156, 20);
            this.mtbCelular.TabIndex = 26;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(12, 71);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(376, 267);
            this.tc.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "Solicitações";
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.Control;
            this.tbID.Location = new System.Drawing.Point(411, 235);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(156, 20);
            this.tbID.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(408, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID";
            // 
            // frmManipularSolicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 376);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnNegar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.cbCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManipularSolicitacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipular solicitações";
            this.Load += new System.EventHandler(this.frmManipularSolicitacoes_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Mensagem;
        private System.Windows.Forms.Button btnNegar;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
    }
}