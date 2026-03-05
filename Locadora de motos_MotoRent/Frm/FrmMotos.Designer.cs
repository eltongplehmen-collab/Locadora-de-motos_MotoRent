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
            btnRevisar = new Button();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtValorDiaria = new TextBox();
            dgvMotos = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            btnAtualizacao = new Button();
            label5 = new Label();
            txtAno = new TextBox();
            label7 = new Label();
            txtPlaca = new TextBox();
            label8 = new Label();
            txtCategoria = new TextBox();
            label9 = new Label();
            txtStatus = new TextBox();
            dtCadastro = new DateTimePicker();
            dtAtualizacao = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvMotos).BeginInit();
            SuspendLayout();
            // 
            // btnRevisar
            // 
            btnRevisar.Location = new Point(18, 469);
            btnRevisar.Name = "btnRevisar";
            btnRevisar.Size = new Size(84, 26);
            btnRevisar.TabIndex = 1;
            btnRevisar.Text = "Revisar";
            btnRevisar.UseVisualStyleBackColor = true;
            btnRevisar.Click += btnRevisar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(12, 93);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(12, 38);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 4;
            // 
            // txtValorDiaria
            // 
            txtValorDiaria.Location = new Point(12, 309);
            txtValorDiaria.Name = "txtValorDiaria";
            txtValorDiaria.Size = new Size(100, 23);
            txtValorDiaria.TabIndex = 5;
            // 
            // dgvMotos
            // 
            dgvMotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotos.Location = new Point(233, 12);
            dgvMotos.Name = "dgvMotos";
            dgvMotos.Size = new Size(588, 606);
            dgvMotos.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 10;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 291);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 11;
            label4.Text = "Valor Diaria:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(18, 501);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(84, 26);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(119, 469);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(84, 26);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizacao
            // 
            btnAtualizacao.Location = new Point(119, 501);
            btnAtualizacao.Name = "btnAtualizacao";
            btnAtualizacao.Size = new Size(84, 26);
            btnAtualizacao.TabIndex = 14;
            btnAtualizacao.Text = "Atualização";
            btnAtualizacao.UseVisualStyleBackColor = true;
            btnAtualizacao.Click += btnAtualizacao_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 18;
            label5.Text = "Ano:";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(12, 149);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(12, 187);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 19;
            label7.Text = "Placa:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(12, 205);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(100, 23);
            txtPlaca.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(14, 240);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 21;
            label8.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(12, 258);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(14, 338);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 23;
            label9.Text = "Status:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(12, 356);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 24;
            // 
            // dtCadastro
            // 
            dtCadastro.Location = new Point(12, 394);
            dtCadastro.Name = "dtCadastro";
            dtCadastro.Size = new Size(200, 23);
            dtCadastro.TabIndex = 25;
            // 
            // dtAtualizacao
            // 
            dtAtualizacao.Location = new Point(12, 437);
            dtAtualizacao.Name = "dtAtualizacao";
            dtAtualizacao.Size = new Size(200, 23);
            dtAtualizacao.TabIndex = 26;
            // 
            // FrmMotos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(823, 630);
            Controls.Add(dtAtualizacao);
            Controls.Add(dtCadastro);
            Controls.Add(txtStatus);
            Controls.Add(label9);
            Controls.Add(txtCategoria);
            Controls.Add(label8);
            Controls.Add(txtPlaca);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtAno);
            Controls.Add(btnAtualizacao);
            Controls.Add(btnCadastrar);
            Controls.Add(btnExcluir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvMotos);
            Controls.Add(txtValorDiaria);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(btnRevisar);
            Name = "FrmMotos";
            Text = "FrmMotos";
            ((System.ComponentModel.ISupportInitialize)dgvMotos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRevisar;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtValorDiaria;
        private DataGridView dgvMotos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnExcluir;
        private Button btnCadastrar;
        private Button btnAtualizacao;
        private Label label5;
        private TextBox txtAno;
        private Label label7;
        private TextBox txtPlaca;
        private Label label8;
        private TextBox txtCategoria;
        private Label label9;
        private TextBox txtStatus;
        private DateTimePicker dtCadastro;
        private DateTimePicker dtAtualizacao;
    }
}