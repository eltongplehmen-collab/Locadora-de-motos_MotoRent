namespace Locadora_de_motos_MotoRent.Frm
{
    partial class FrmAlugar
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
            label5 = new Label();
            txtAno = new TextBox();
            btnAlugar = new Button();
            btnLimpar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtUsuario = new TextBox();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            dataGridView1 = new DataGridView();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 36;
            label5.Text = "Ano:";
            // 
            // txtAno
            // 
            txtAno.BackColor = Color.White;
            txtAno.Location = new Point(12, 158);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 34;
            // 
            // btnAlugar
            // 
            btnAlugar.BackColor = Color.FromArgb(255, 224, 192);
            btnAlugar.Location = new Point(246, 703);
            btnAlugar.Name = "btnAlugar";
            btnAlugar.Size = new Size(94, 25);
            btnAlugar.TabIndex = 31;
            btnAlugar.Text = "Alugar";
            btnAlugar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 224, 192);
            btnLimpar.Location = new Point(15, 703);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 25);
            btnLimpar.TabIndex = 30;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 28;
            label3.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 27;
            label2.Text = "Modelo:";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.White;
            txtMarca.Location = new Point(12, 100);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 22;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.White;
            txtModelo.Location = new Point(12, 42);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 21;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 224, 192);
            btnBuscar.Location = new Point(135, 703);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 25);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 223);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 37;
            label1.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(13, 349);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 38;
            label4.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(12, 287);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 39;
            label6.Text = "Telefone:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Location = new Point(12, 241);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 40;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.White;
            txtTelefone.Location = new Point(12, 305);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 41;
            // 
            // txtCPF
            // 
            txtCPF.BackColor = Color.White;
            txtCPF.Location = new Point(12, 368);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(131, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(359, 386);
            dataGridView1.TabIndex = 43;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 224, 192);
            btnSair.Location = new Point(396, 703);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 25);
            btnSair.TabIndex = 44;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmAlugar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(502, 740);
            Controls.Add(btnSair);
            Controls.Add(dataGridView1);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(txtUsuario);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(txtAno);
            Controls.Add(btnAlugar);
            Controls.Add(btnLimpar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(btnBuscar);
            Name = "FrmAlugar";
            Text = "FrmAlugar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtAno;
        private TextBox txtPreco;
        private Button btnAlugar;
        private Button btnLimpar;
        private Label label3;
        private Label label2;
        private DataGridView dgvMotos;
        private ComboBox cmbStatus;
        private TextBox txtValorDiaria;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtIdMoto;
        private Button btnBuscar;
        private Label label1;
        private Label label4;
        private Label label6;
        private TextBox txtUsuario;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private DataGridView dataGridView1;
        private Button btnSair;
    }
}