namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmTelaPrincipalAdmin
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
            btnMotos = new Button();
            btnClientes = new Button();
            btnFuncionario = new Button();
            btnDevolucao = new Button();
            btnSair = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // btnMotos
            // 
            btnMotos.BackColor = Color.Beige;
            btnMotos.Location = new Point(86, 41);
            btnMotos.Name = "btnMotos";
            btnMotos.Size = new Size(180, 55);
            btnMotos.TabIndex = 0;
            btnMotos.Text = "Motos";
            btnMotos.UseVisualStyleBackColor = false;
            btnMotos.Click += btnMotos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Beige;
            btnClientes.Location = new Point(86, 119);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(180, 55);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.Beige;
            btnFuncionario.Location = new Point(86, 199);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(180, 55);
            btnFuncionario.TabIndex = 2;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnDevolucao
            // 
            btnDevolucao.BackColor = Color.Beige;
            btnDevolucao.Location = new Point(86, 281);
            btnDevolucao.Name = "btnDevolucao";
            btnDevolucao.Size = new Size(180, 55);
            btnDevolucao.TabIndex = 3;
            btnDevolucao.Text = "Devolução";
            btnDevolucao.UseVisualStyleBackColor = false;
            btnDevolucao.Click += btnDevolucao_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.IndianRed;
            btnSair.Location = new Point(120, 477);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(132, 42);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Beige;
            btnCadastrar.Location = new Point(86, 361);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(180, 55);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // FrmTelaPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(364, 585);
            Controls.Add(btnCadastrar);
            Controls.Add(btnSair);
            Controls.Add(btnDevolucao);
            Controls.Add(btnFuncionario);
            Controls.Add(btnClientes);
            Controls.Add(btnMotos);
            Name = "FrmTelaPrincipalAdmin";
            Text = "FrmTelaPrincipal";
            Load += FrmTelaPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMotos;
        private Button btnClientes;
        private Button btnFuncionario;
        private Button btnDevolucao;
        private Button btnSair;
        private Button btnCadastrar;
    }
}