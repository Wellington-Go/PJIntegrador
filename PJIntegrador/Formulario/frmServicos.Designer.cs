namespace PJIntegrador.Formulario
{
    partial class frmServicos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarAlterar = new System.Windows.Forms.Button();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditarAlterar);
            this.groupBox1.Controls.Add(this.cmbIdCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de Serviço";
            // 
            // btnEditarAlterar
            // 
            this.btnEditarAlterar.Location = new System.Drawing.Point(9, 211);
            this.btnEditarAlterar.Name = "btnEditarAlterar";
            this.btnEditarAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnEditarAlterar.TabIndex = 16;
            this.btnEditarAlterar.Text = "Alterar";
            this.btnEditarAlterar.UseVisualStyleBackColor = true;
            this.btnEditarAlterar.Click += new System.EventHandler(this.btnEditarAlterar_Click);
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(9, 129);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(100, 21);
            this.cmbIdCliente.TabIndex = 14;
            this.cmbIdCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIdCliente_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id do Cliente:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(33, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 20);
            this.txtId.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.clnNome,
            this.clnSenha,
            this.clnCpf,
            this.Valor});
            this.dgvServicos.Location = new System.Drawing.Point(266, 41);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            this.dgvServicos.RowHeadersVisible = false;
            this.dgvServicos.Size = new System.Drawing.Size(521, 214);
            this.dgvServicos.TabIndex = 20;
            this.dgvServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicos_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(266, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvId
            // 
            this.dgvId.Frozen = true;
            this.dgvId.HeaderText = "ID";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Descrição";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 250;
            // 
            // clnSenha
            // 
            this.clnSenha.Frozen = true;
            this.clnSenha.HeaderText = "Data";
            this.clnSenha.Name = "clnSenha";
            this.clnSenha.ReadOnly = true;
            this.clnSenha.Width = 90;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "ID Cliente";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 70;
            // 
            // Valor
            // 
            this.Valor.Frozen = true;
            this.Valor.HeaderText = "valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(9, 185);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 265);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvServicos);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmServicos";
            this.Text = "Servicos";
            this.Load += new System.EventHandler(this.frmServicos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.Button btnEditarAlterar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}