namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmTelaLoginUsuario
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
            btnContinuar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(60, 163);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(100, 37);
            btnContinuar.TabIndex = 9;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(16, 105);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(179, 23);
            txtSenha.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(16, 34);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(179, 23);
            txtUsuario.TabIndex = 5;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(60, 224);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 37);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmTelaLoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(267, 384);
            Controls.Add(btnSair);
            Controls.Add(btnContinuar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "FrmTelaLoginUsuario";
            Text = "FrmTelaLoginUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContinuar;
        private Label label2;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Button btnSair;
    }
}