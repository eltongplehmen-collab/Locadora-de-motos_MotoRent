namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmFuncionarios
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
            btnExcluir = new Button();
            btnCadastrar = new Button();
            btnBuscar = new Button();
            btnSair = new Button();
            btnListar = new Button();
            dgvFuncionarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(155, 162);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(97, 45);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(23, 162);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(97, 45);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(155, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 45);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(73, 393);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(133, 45);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(23, 85);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(97, 45);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(271, 2);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.Size = new Size(240, 448);
            dgvFuncionarios.TabIndex = 6;
            // 
            // FrmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(512, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(btnBuscar);
            Controls.Add(btnSair);
            Controls.Add(btnListar);
            Controls.Add(dgvFuncionarios);
            Name = "FrmFuncionarios";
            Text = "FrmFuncionarios";
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExcluir;
        private Button btnCadastrar;
        private Button btnBuscar;
        private Button btnSair;
        private Button btnListar;
        private DataGridView dgvFuncionarios;
    }
}