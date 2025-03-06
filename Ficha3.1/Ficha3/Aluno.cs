using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    class Aluno : Pessoa
    {
        public string nrAluno;
        public string curso;

        public Aluno(string nome, DateTime dataNascimento, string nrAluno, string curso)
                : base(nome, dataNascimento)
        {
            this.nrAluno = nrAluno;
            this.curso = curso;
        }
        public string Mostrar()
        {
            return $"{nome}    \n\tNr Aluno: {nrAluno}, " +
                   $"          \n\tData de Nascimento: {dataNascimento.ToString("dd/mm/yyyy")}, " +
                   $"          \n\tCurso: {curso}, " +
                   $"          \n\tPontuação: {pontuacao}";
        }
    }
}
