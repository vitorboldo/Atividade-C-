namespace Exe3_NotasAlunos
{
    partial class frmNotasAlunos
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
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnCriarAluno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotaBimestral = new System.Windows.Forms.TextBox();
            this.txtNotaMensal = new System.Windows.Forms.TextBox();
            this.btnNotas = new System.Windows.Forms.Button();
            this.dgvMostrarMedia = new System.Windows.Forms.DataGridView();
            this.NomeDoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaMensal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaBimestral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(205, 9);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(297, 32);
            this.txtNomeAluno.TabIndex = 2;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(101, 68);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(401, 32);
            this.txtCurso.TabIndex = 3;
            // 
            // btnCriarAluno
            // 
            this.btnCriarAluno.Location = new System.Drawing.Point(20, 131);
            this.btnCriarAluno.Name = "btnCriarAluno";
            this.btnCriarAluno.Size = new System.Drawing.Size(482, 43);
            this.btnCriarAluno.TabIndex = 4;
            this.btnCriarAluno.Text = "Criar Aluno";
            this.btnCriarAluno.UseVisualStyleBackColor = true;
            this.btnCriarAluno.Click += new System.EventHandler(this.btnCriarAluno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota Mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota Bimestral";
            // 
            // txtNotaBimestral
            // 
            this.txtNotaBimestral.Location = new System.Drawing.Point(218, 285);
            this.txtNotaBimestral.Name = "txtNotaBimestral";
            this.txtNotaBimestral.Size = new System.Drawing.Size(106, 32);
            this.txtNotaBimestral.TabIndex = 7;
            // 
            // txtNotaMensal
            // 
            this.txtNotaMensal.Location = new System.Drawing.Point(179, 209);
            this.txtNotaMensal.Name = "txtNotaMensal";
            this.txtNotaMensal.Size = new System.Drawing.Size(145, 32);
            this.txtNotaMensal.TabIndex = 8;
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(20, 355);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(482, 43);
            this.btnNotas.TabIndex = 9;
            this.btnNotas.Text = "Notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // dgvMostrarMedia
            // 
            this.dgvMostrarMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeDoAluno,
            this.Curso,
            this.NotaMensal,
            this.NotaBimestral,
            this.MediaFinal});
            this.dgvMostrarMedia.Location = new System.Drawing.Point(20, 420);
            this.dgvMostrarMedia.Name = "dgvMostrarMedia";
            this.dgvMostrarMedia.Size = new System.Drawing.Size(1085, 272);
            this.dgvMostrarMedia.TabIndex = 10;
            // 
            // NomeDoAluno
            // 
            this.NomeDoAluno.HeaderText = "Nome do aluno";
            this.NomeDoAluno.Name = "NomeDoAluno";
            this.NomeDoAluno.Width = 210;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.Width = 210;
            // 
            // NotaMensal
            // 
            this.NotaMensal.HeaderText = "Nota Mensal";
            this.NotaMensal.Name = "NotaMensal";
            this.NotaMensal.Width = 210;
            // 
            // NotaBimestral
            // 
            this.NotaBimestral.HeaderText = "Nota Bimestral";
            this.NotaBimestral.Name = "NotaBimestral";
            this.NotaBimestral.Width = 230;
            // 
            // MediaFinal
            // 
            this.MediaFinal.HeaderText = "Média Final";
            this.MediaFinal.Name = "MediaFinal";
            this.MediaFinal.Width = 180;
            // 
            // frmNotasAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 796);
            this.Controls.Add(this.dgvMostrarMedia);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.txtNotaMensal);
            this.Controls.Add(this.txtNotaBimestral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCriarAluno);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "frmNotasAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas Bimestrais de todos os alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnCriarAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotaBimestral;
        private System.Windows.Forms.TextBox txtNotaMensal;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.DataGridView dgvMostrarMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaMensal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaBimestral;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaFinal;
    }
}

