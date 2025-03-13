using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    class AlunoEspecial : Aluno
    {
        public string dificuldade;

        public AlunoEspecial(string nome, DateTime dataNascimento, string nrAluno, string curso, string dificuldade)
                            : base(nome, dataNascimento, nrAluno, curso)
        {
            this.dificuldade = dificuldade;
        }
        public string Mostrar()
        {
            return $"{nome}    \n\tData de Nascimento: {dataNascimento.ToString("dd/MM/yyyy")}, " +
                   $"          \n\tDificuldade: {dificuldade}, " +
                   $"          \n\tPontuação: {pontuacao}";
        }
    }
}
