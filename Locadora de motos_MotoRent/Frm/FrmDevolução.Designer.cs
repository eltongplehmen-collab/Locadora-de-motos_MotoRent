namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmDevolução
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
            btnListar = new Button();
            btnDevolucao = new Button();
            dgvMotos = new DataGridView();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMotos).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(235, 393);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(183, 45);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(15, 393);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(183, 45);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnDevolucao
            // 
            btnDevolucao.Location = new Point(458, 393);
            btnDevolucao.Name = "btnDevolucao";
            btnDevolucao.Size = new Size(183, 45);
            btnDevolucao.TabIndex = 6;
            btnDevolucao.Text = "Devolução";
            btnDevolucao.UseVisualStyleBackColor = true;
            btnDevolucao.Click += btnDevolucao_Click;
            // 
            // dgvMotos
            // 
            dgvMotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotos.Location = new Point(-1, 0);
            dgvMotos.Name = "dgvMotos";
            dgvMotos.Size = new Size(802, 280);
            dgvMotos.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(687, 393);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(101, 45);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmDevolução
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(dgvMotos);
            Controls.Add(btnDevolucao);
            Controls.Add(btnBuscar);
            Controls.Add(btnListar);
            Name = "FrmDevolução";
            Text = "FrmDevolução";
            ((System.ComponentModel.ISupportInitialize)dgvMotos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Button btnListar;
        private Button btnDevolucao;
        private DataGridView dgvMotos;
        private Button btnSair;
    }
}