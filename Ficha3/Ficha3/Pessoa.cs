using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    public class Pessoa
    {
        public string nome;
        public DateTime dataNascimento;
        public string morada;
        public int pontuacao;

        public Pessoa(string nome, DateTime dataNascimento, string morada)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.morada = morada;
            this.pontuacao = 0;
        }
        public override string ToString()
        {
            return this.nome + " (" + idade() + ") " + this.pontuacao;
        } 
        public int idade()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dataNascimento.Year;
            if (dataNascimento.Date > today.AddYears(-age)) 
            { 
                age--; 
            }

            return age;
        }

        public void pontuar(int pontos)
        {
            this.pontuacao = this.pontuacao + pontos;
        }
    }
}
