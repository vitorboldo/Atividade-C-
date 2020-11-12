﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe3_NotasAlunos
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Curso { get; set; }

        public Aluno (string nome)
        {
            this.Nome = nome;
        }

        public Aluno (string nome, string curso)
        {
            this.Nome = nome;
            this.Curso = curso;
        }
    }
}
