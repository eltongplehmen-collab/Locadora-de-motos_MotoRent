namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmClientes
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
            dgvClientes = new DataGridView();
            btnListar = new Button();
            btnSair = new Button();
            btnBuscar = new Button();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(260, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(240, 448);
            dgvClientes.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(12, 85);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(97, 45);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(62, 393);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(133, 45);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(144, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 45);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 162);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(97, 45);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(144, 162);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(97, 45);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(501, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(btnBuscar);
            Controls.Add(btnSair);
            Controls.Add(btnListar);
            Controls.Add(dgvClientes);
            Name = "FrmClientes";
            Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnListar;
        private Button btnSair;
        private Button btnBuscar;
        private Button btnCadastrar;
        private Button btnExcluir;
    }
}