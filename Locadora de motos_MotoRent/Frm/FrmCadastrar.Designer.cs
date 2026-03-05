namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmCadastrar
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
            dgvRevisar = new DataGridView();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCadastrar = new Button();
            btnRevisar = new Button();
            btnSair = new Button();
            txtCNH = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRevisar).BeginInit();
            SuspendLayout();
            // 
            // dgvRevisar
            // 
            dgvRevisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevisar.Location = new Point(233, 12);
            dgvRevisar.Name = "dgvRevisar";
            dgvRevisar.Size = new Size(367, 546);
            dgvRevisar.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 149);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 204);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "CPF:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 361);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(114, 36);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnRevisar
            // 
            btnRevisar.Location = new Point(12, 314);
            btnRevisar.Name = "btnRevisar";
            btnRevisar.Size = new Size(114, 36);
            btnRevisar.TabIndex = 13;
            btnRevisar.Text = "Revisar:";
            btnRevisar.UseVisualStyleBackColor = true;
            btnRevisar.Click += btnRevisar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(12, 785);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(114, 36);
            btnSair.TabIndex = 14;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtCNH
            // 
            txtCNH.Location = new Point(12, 261);
            txtCNH.Name = "txtCNH";
            txtCNH.Size = new Size(100, 23);
            txtCNH.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(12, 243);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 18;
            label6.Text = "CNH:";
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(612, 831);
            Controls.Add(label6);
            Controls.Add(txtCNH);
            Controls.Add(btnSair);
            Controls.Add(btnRevisar);
            Controls.Add(btnCadastrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(dgvRevisar);
            Name = "FrmCadastrar";
            Text = "FrmCadastrar";
            ((System.ComponentModel.ISupportInitialize)dgvRevisar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRevisar;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCadastrar;
        private Button btnRevisar;
        private Button btnSair;
        private TextBox txtCNH;
        private Label label6;
    }
}