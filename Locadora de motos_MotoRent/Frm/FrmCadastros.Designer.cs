namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmCadastros
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
            btnSair = new Button();
            dgvCadastros = new DataGridView();
            dgvFuncionarios = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(310, 393);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(133, 45);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // dgvCadastros
            // 
            dgvCadastros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCadastros.Location = new Point(12, 22);
            dgvCadastros.Name = "dgvCadastros";
            dgvCadastros.Size = new Size(477, 160);
            dgvCadastros.TabIndex = 6;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(12, 227);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.Size = new Size(477, 160);
            dgvFuncionarios.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 11;
            label1.Text = "Clientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 13;
            label3.Text = "Funcionarios";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(68, 393);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(133, 45);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // FrmCadastros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(501, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvFuncionarios);
            Controls.Add(btnSair);
            Controls.Add(dgvCadastros);
            Name = "FrmCadastros";
            Text = "FrmCadastros";
            ((System.ComponentModel.ISupportInitialize)dgvCadastros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSair;
        private DataGridView dgvCadastros;
        private DataGridView dgvFuncionarios;
        private Label label1;
        private Label label3;
        private Button btnAtualizar;
    }
}