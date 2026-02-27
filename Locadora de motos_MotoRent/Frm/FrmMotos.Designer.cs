namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmMotos
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
            btnListar = new Button();
            txtIdMoto = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtValorDiaria = new TextBox();
            cmbStatus = new ComboBox();
            dgvMotos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            btnAtualizacao = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMotos).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(9, 279);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(84, 26);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtIdMoto
            // 
            txtIdMoto.Location = new Point(12, 33);
            txtIdMoto.Name = "txtIdMoto";
            txtIdMoto.Size = new Size(100, 23);
            txtIdMoto.TabIndex = 2;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(12, 82);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 140);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 4;
            // 
            // txtValorDiaria
            // 
            txtValorDiaria.Location = new Point(12, 202);
            txtValorDiaria.Name = "txtValorDiaria";
            txtValorDiaria.Size = new Size(100, 23);
            txtValorDiaria.TabIndex = 5;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Indisponivel", "Disponivel" });
            cmbStatus.Location = new Point(12, 241);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 6;
            // 
            // dgvMotos
            // 
            dgvMotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotos.Location = new Point(220, 1);
            dgvMotos.Name = "dgvMotos";
            dgvMotos.Size = new Size(240, 452);
            dgvMotos.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 8;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 10;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 184);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 11;
            label4.Text = "Valor Diaria:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(9, 311);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(84, 26);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(110, 279);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(84, 26);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizacao
            // 
            btnAtualizacao.Location = new Point(110, 311);
            btnAtualizacao.Name = "btnAtualizacao";
            btnAtualizacao.Size = new Size(84, 26);
            btnAtualizacao.TabIndex = 14;
            btnAtualizacao.Text = "Atualização";
            btnAtualizacao.UseVisualStyleBackColor = true;
            // 
            // FrmMotos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(460, 450);
            Controls.Add(btnAtualizacao);
            Controls.Add(btnCadastrar);
            Controls.Add(btnExcluir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMotos);
            Controls.Add(cmbStatus);
            Controls.Add(txtValorDiaria);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(txtIdMoto);
            Controls.Add(btnListar);
            Name = "FrmMotos";
            Text = "FrmMotos";
            Load += FrmMotos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMotos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListar;
        private TextBox txtIdMoto;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtValorDiaria;
        private ComboBox cmbStatus;
        private DataGridView dgvMotos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnExcluir;
        private Button btnCadastrar;
        private Button btnAtualizacao;
    }
}