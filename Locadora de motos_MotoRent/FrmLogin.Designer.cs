namespace Locadora_de_motos_MotoRent
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuario = new Button();
            btnAdministrador = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(255, 224, 192);
            btnUsuario.Location = new Point(21, 201);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(146, 48);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnAdministrador
            // 
            btnAdministrador.BackColor = Color.FromArgb(255, 224, 192);
            btnAdministrador.Location = new Point(211, 201);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(146, 48);
            btnAdministrador.TabIndex = 1;
            btnAdministrador.Text = "Admin";
            btnAdministrador.UseVisualStyleBackColor = false;
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(3, 407);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 40);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(387, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnAdministrador);
            Controls.Add(btnUsuario);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnAdministrador;
        private Button btnFechar;
    }
}
