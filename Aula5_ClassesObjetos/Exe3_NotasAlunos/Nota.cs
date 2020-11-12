using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Exe3_NotasAlunos
{
    class Nota
    {
        private Aluno aluno;
        private double notaMensal;
        private double notaBimestral;

        public Nota(Aluno aluno, double notaMensal, double notaBimestral)
        {
            this.aluno = aluno;
            this.NotaMensal = notaMensal;
            this.NotaBimestral = notaBimestral;
        }

        public double NotaMensal
        {
            get
            {
                return this.notaMensal;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.notaMensal = value;

                }
                else
                {
                    this.notaMensal = 0;
                }
                
            }
        }

        public double NotaBimestral
        {
            get
            {
                return this.notaBimestral;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.notaBimestral = value;

                }
                else
                {
                    this.notaBimestral = 0;
                }
            }
        }

        public double MediaFinal()
        {
            double mediaFinal;

            mediaFinal = (notaMensal + notaBimestral) / 2;

            return mediaFinal;
        }
    }
}
