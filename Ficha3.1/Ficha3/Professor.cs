using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    class Professor : Pessoa
    {
        public string disciplina;

        public Professor(string nome, DateTime dataNascimento, string disciplina)
                        : base(nome, dataNascimento)
        {
            this.disciplina = disciplina;
        }
        public string Mostrar()
        {
            return $"{nome}    \n\tData de Nascimento: {dataNascimento.ToString("dd/mm/yyyy")}, " +
                   $"          \n\tDisciplina: {disciplina}, " +
                   $"          \n\tPontuação: {pontuacao}";
        }
    }
}
