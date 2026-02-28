namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmTelaPrincipalUsuario
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
            btnDevolucao = new Button();
            btnSair = new Button();
            btnCadastros = new Button();
            btnAlugar = new Button();
            SuspendLayout();
            // 
            // btnDevolucao
            // 
            btnDevolucao.BackColor = Color.Beige;
            btnDevolucao.Location = new Point(103, 24);
            btnDevolucao.Name = "btnDevolucao";
            btnDevolucao.Size = new Size(180, 55);
            btnDevolucao.TabIndex = 7;
            btnDevolucao.Text = "Devolução";
            btnDevolucao.UseVisualStyleBackColor = false;
            btnDevolucao.Click += btnDevolucao_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.IndianRed;
            btnSair.Location = new Point(134, 298);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(132, 42);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnCadastros
            // 
            btnCadastros.BackColor = Color.Beige;
            btnCadastros.Location = new Point(103, 109);
            btnCadastros.Name = "btnCadastros";
            btnCadastros.Size = new Size(180, 55);
            btnCadastros.TabIndex = 9;
            btnCadastros.Text = "Cadastros";
            btnCadastros.UseVisualStyleBackColor = false;
            btnCadastros.Click += btnCadastros_Click;
            // 
            // btnAlugar
            // 
            btnAlugar.BackColor = Color.Beige;
            btnAlugar.Location = new Point(103, 202);
            btnAlugar.Name = "btnAlugar";
            btnAlugar.Size = new Size(180, 55);
            btnAlugar.TabIndex = 10;
            btnAlugar.Text = "Alugar";
            btnAlugar.UseVisualStyleBackColor = false;
            btnAlugar.Click += btnAlugar_Click;
            // 
            // FrmTelaPrincipalUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(398, 537);
            Controls.Add(btnAlugar);
            Controls.Add(btnCadastros);
            Controls.Add(btnSair);
            Controls.Add(btnDevolucao);
            Name = "FrmTelaPrincipalUsuario";
            Text = "TelaPrincipalUsuario";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDevolucao;
        private Button btnSair;
        private Button btnCadastros;
        private Button btnAlugar;
    }
}