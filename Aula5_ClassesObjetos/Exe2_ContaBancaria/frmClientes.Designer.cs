namespace Exe2_ContaBancaria
{
    partial class frmClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.txtRgCliente = new System.Windows.Forms.TextBox();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.btnCriarClienteV1 = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCriarClienteV2 = new System.Windows.Forms.Button();
            this.btnCriarClienteV3 = new System.Windows.Forms.Button();
            this.btnCriarClienteV4_1 = new System.Windows.Forms.Button();
            this.btnCriarClienteV4_2 = new System.Windows.Forms.Button();
            this.btnCriarClienteV4_3 = new System.Windows.Forms.Button();
            this.btnCriarClienteV4_4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(139, 22);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(320, 32);
            this.txtNomeCliente.TabIndex = 4;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(139, 79);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(320, 32);
            this.txtCpfCliente.TabIndex = 5;
            // 
            // txtRgCliente
            // 
            this.txtRgCliente.Location = new System.Drawing.Point(139, 127);
            this.txtRgCliente.Name = "txtRgCliente";
            this.txtRgCliente.Size = new System.Drawing.Size(320, 32);
            this.txtRgCliente.TabIndex = 6;
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(139, 184);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(320, 32);
            this.txtEnderecoCliente.TabIndex = 7;
            // 
            // btnCriarClienteV1
            // 
            this.btnCriarClienteV1.Location = new System.Drawing.Point(49, 234);
            this.btnCriarClienteV1.Name = "btnCriarClienteV1";
            this.btnCriarClienteV1.Size = new System.Drawing.Size(410, 37);
            this.btnCriarClienteV1.TabIndex = 8;
            this.btnCriarClienteV1.Text = "Criar Cliente V1";
            this.btnCriarClienteV1.UseVisualStyleBackColor = true;
            this.btnCriarClienteV1.Click += new System.EventHandler(this.btnCriarClienteV1_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.RG,
            this.Endereço});
            this.dgvClientes.Location = new System.Drawing.Point(484, 22);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(465, 348);
            this.dgvClientes.TabIndex = 9;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.Width = 120;
            // 
            // btnCriarClienteV2
            // 
            this.btnCriarClienteV2.Location = new System.Drawing.Point(49, 301);
            this.btnCriarClienteV2.Name = "btnCriarClienteV2";
            this.btnCriarClienteV2.Size = new System.Drawing.Size(410, 37);
            this.btnCriarClienteV2.TabIndex = 10;
            this.btnCriarClienteV2.Text = "Criar Cliente V2";
            this.btnCriarClienteV2.UseVisualStyleBackColor = true;
            this.btnCriarClienteV2.Click += new System.EventHandler(this.btnCriarClienteV2_Click);
            // 
            // btnCriarClienteV3
            // 
            this.btnCriarClienteV3.Location = new System.Drawing.Point(49, 368);
            this.btnCriarClienteV3.Name = "btnCriarClienteV3";
            this.btnCriarClienteV3.Size = new System.Drawing.Size(410, 37);
            this.btnCriarClienteV3.TabIndex = 11;
            this.btnCriarClienteV3.Text = "Criar Cliente V3";
            this.btnCriarClienteV3.UseVisualStyleBackColor = true;
            this.btnCriarClienteV3.Click += new System.EventHandler(this.btnCriarClienteV3_Click);
            // 
            // btnCriarClienteV4_1
            // 
            this.btnCriarClienteV4_1.Location = new System.Drawing.Point(49, 434);
            this.btnCriarClienteV4_1.Name = "btnCriarClienteV4_1";
            this.btnCriarClienteV4_1.Size = new System.Drawing.Size(410, 37);
            this.btnCriarClienteV4_1.TabIndex = 12;
            this.btnCriarClienteV4_1.Text = "Criar Cliente V4_1";
            this.btnCriarClienteV4_1.UseVisualStyleBackColor = true;
            this.btnCriarClienteV4_1.Click += new System.EventHandler(this.btnCriarClienteV4_1_Click);
            // 
            // btnCriarClienteV4_2
            // 
            this.btnCriarClienteV4_2.Location = new System.Drawing.Point(49, 501);
            this.btnCriarClienteV4_2.Name = "btnCriarClienteV4_2";
            this.btnCriarClienteV4_2.Size = new System.Drawing.Size(410, 37);
            this.btnCriarClienteV4_2.TabIndex = 13;
            this.btnCriarClienteV4_2.Text = "Criar Cliente V4_2";
            this.btnCriarClienteV4_2.UseVisualStyleBackColor = true;
            this.btnCriarClienteV4_2.Click += new System.EventHandler(this.btnCriarClienteV4_2_Click);
            // 
            // btnCriarClienteV4_3
            // 
            this.btnCriarClienteV4_3.Location = new System.Drawing.Point(49, 565);
            this.btnCriarClienteV4_3.Name = "btnCriarClienteV4_3";
            this.btnCriarClienteV4_3.Size = new System.Drawing.Size(410, 37);
            this.btnCriarClienteV4_3.TabIndex = 14;
            this.btnCriarClienteV4_3.Text = "Criar Cliente V4_3";
            this.btnCriarClienteV4_3.UseVisualStyleBackColor = true;
            this.btnCriarClienteV4_3.Click += new System.EventHandler(this.btnCriarClienteV4_3_Click);
            // 
            // btnCriarClienteV4_4
            // 
            this.btnCriarClienteV4_4.Location = new System.Drawing.Point(49, 628);
            this.btnCriarClienteV4_4.Name = "btnCriarClienteV4_4";
            this.btnCriarClienteV4_4.Size = new System.Drawing.Size(410, 37);
            this.btnCriarClienteV4_4.TabIndex = 15;
            this.btnCriarClienteV4_4.Text = "Criar Cliente V4_4";
            this.btnCriarClienteV4_4.UseVisualStyleBackColor = true;
            this.btnCriarClienteV4_4.Click += new System.EventHandler(this.btnCriarClienteV4_4_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 796);
            this.Controls.Add(this.btnCriarClienteV4_4);
            this.Controls.Add(this.btnCriarClienteV4_3);
            this.Controls.Add(this.btnCriarClienteV4_2);
            this.Controls.Add(this.btnCriarClienteV4_1);
            this.Controls.Add(this.btnCriarClienteV3);
            this.Controls.Add(this.btnCriarClienteV2);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCriarClienteV1);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.txtRgCliente);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCpfCliente;
        private System.Windows.Forms.TextBox txtRgCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Button btnCriarClienteV1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.Button btnCriarClienteV2;
        private System.Windows.Forms.Button btnCriarClienteV3;
        private System.Windows.Forms.Button btnCriarClienteV4_1;
        private System.Windows.Forms.Button btnCriarClienteV4_2;
        private System.Windows.Forms.Button btnCriarClienteV4_3;
        private System.Windows.Forms.Button btnCriarClienteV4_4;
    }
}

