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
            btnBuscar = new Button();
            btnSair = new Button();
            btnListar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(23, 116);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 45);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(13, 397);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(133, 45);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(23, 25);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(97, 45);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(152, 1);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(350, 448);
            dgvClientes.TabIndex = 6;
            // 
            // FrmCadastros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(501, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnSair);
            Controls.Add(btnListar);
            Controls.Add(dgvClientes);
            Name = "FrmCadastros";
            Text = "FrmCadastros";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Button btnSair;
        private Button btnListar;
        private DataGridView dgvClientes;
    }
}