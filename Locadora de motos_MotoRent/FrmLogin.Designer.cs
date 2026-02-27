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
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(21, 201);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(146, 48);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnAdministrador
            // 
            btnAdministrador.Location = new Point(211, 201);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(146, 48);
            btnAdministrador.TabIndex = 1;
            btnAdministrador.Text = "Admin";
            btnAdministrador.UseVisualStyleBackColor = true;
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 450);
            Controls.Add(btnAdministrador);
            Controls.Add(btnUsuario);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnAdministrador;
    }
}
