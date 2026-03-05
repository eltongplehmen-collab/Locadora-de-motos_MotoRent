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
            btnAlugar = new Button();
            btnLimpar = new Button();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            btnSair = new Button();
            txtPlaca = new TextBox();
            txtClienteId = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAlugar
            // 
            btnAlugar.BackColor = Color.FromArgb(255, 224, 192);
            btnAlugar.Location = new Point(246, 447);
            btnAlugar.Name = "btnAlugar";
            btnAlugar.Size = new Size(94, 25);
            btnAlugar.TabIndex = 31;
            btnAlugar.Text = "Alugar";
            btnAlugar.UseVisualStyleBackColor = false;
            btnAlugar.Click += btnAlugar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 224, 192);
            btnLimpar.Location = new Point(15, 447);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 25);
            btnLimpar.TabIndex = 30;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 224, 192);
            btnBuscar.Location = new Point(135, 447);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 25);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(218, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(525, 422);
            dataGridView1.TabIndex = 43;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 224, 192);
            btnSair.Location = new Point(396, 447);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 25);
            btnSair.TabIndex = 44;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(15, 37);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(100, 23);
            txtPlaca.TabIndex = 45;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(15, 90);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(100, 23);
            txtClienteId.TabIndex = 46;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(15, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 49;
            label2.Text = "Placa:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(15, 72);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 50;
            label3.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(15, 122);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 51;
            label4.Text = "Valor Diaria:";
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(12, 230);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 52;
            // 
            // dtpFim
            // 
            dtpFim.Location = new Point(12, 259);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(200, 23);
            dtpFim.TabIndex = 53;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Location = new Point(15, 212);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 48;
            lblStatus.Text = "Status";
            // 
            // FrmAlugar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(766, 499);
            Controls.Add(dtpFim);
            Controls.Add(dtpInicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(textBox2);
            Controls.Add(txtClienteId);
            Controls.Add(txtPlaca);
            Controls.Add(btnSair);
            Controls.Add(dataGridView1);
            Controls.Add(btnAlugar);
            Controls.Add(btnLimpar);
            Controls.Add(btnBuscar);
            Name = "FrmAlugar";
            Text = "FrmAlugar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPreco;
        private Button btnAlugar;
        private Button btnLimpar;
        private DataGridView dgvMotos;
        private ComboBox cmbStatus;
        private TextBox txtValorDiaria;
        private TextBox txtIdMoto;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private Button btnSair;
        private TextBox txtPlaca;
        private TextBox txtClienteId;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label lblStatus;
    }
}