using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_NotasAlunos
{
    public partial class frmNotasAlunos : Form
    {
        Aluno aluno;
        Nota nota;
        int numLinha = 0;
        public frmNotasAlunos()
        {
            InitializeComponent();
        }

        private void btnCriarAluno_Click(object sender, EventArgs e)
        {
            aluno = new Aluno(txtNomeAluno.Text, txtCurso.Text);

            dgvMostrarMedia.Rows.Add();
            dgvMostrarMedia[0, numLinha].Value = aluno.Nome;
            dgvMostrarMedia[1, numLinha].Value = aluno.Curso;
            numLinha++;
           
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            nota = new Nota(aluno, Convert.ToDouble(txtNotaMensal.Text), Convert.ToDouble(txtNotaBimestral.Text));
            dgvMostrarMedia.Rows.Add();
            dgvMostrarMedia[0, numLinha].Value = aluno.Nome;
            dgvMostrarMedia[1, numLinha].Value = aluno.Curso;
            dgvMostrarMedia[2, numLinha].Value = nota.NotaMensal;
            dgvMostrarMedia[3, numLinha].Value = nota.NotaBimestral;
            dgvMostrarMedia[4, numLinha].Value = nota.MediaFinal();
            numLinha++;
        }
    }
}
