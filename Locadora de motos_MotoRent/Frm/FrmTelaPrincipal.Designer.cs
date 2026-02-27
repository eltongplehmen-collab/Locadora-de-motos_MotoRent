namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmTelaPrincipal
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
            button1 = new Button();
            btnSair = new Button();
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
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.Location = new Point(86, 281);
            button1.Name = "button1";
            button1.Size = new Size(180, 55);
            button1.TabIndex = 3;
            button1.Text = "Devolução";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.IndianRed;
            btnSair.Location = new Point(112, 375);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(132, 42);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(364, 585);
            Controls.Add(btnSair);
            Controls.Add(button1);
            Controls.Add(btnFuncionario);
            Controls.Add(btnClientes);
            Controls.Add(btnMotos);
            Name = "FrmTelaPrincipal";
            Text = "FrmTelaPrincipal";
            Load += FrmTelaPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMotos;
        private Button btnClientes;
        private Button btnFuncionario;
        private Button button1;
        private Button btnSair;
    }
}