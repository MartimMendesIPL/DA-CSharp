using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    public class Pessoa
    {
        public string nome;
        public DateTime dataNascimento;
        public int pontuacao;
        public string tipoDePessoa;
        public Pessoa(string nome, DateTime dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.pontuacao = 0;
            this.tipoDePessoa = this.GetType().Name;
        }
        public override string ToString()
        {
            return this.nome + " ( " + this.dataNascimento.ToString("dd/MM/yyyy") +  "): " + this.pontuacao + " pontos";
        } 
        public void pontuar(int pontos)
        {
            this.pontuacao = this.pontuacao + pontos;
        }
        public string queTipoDePessoaSou()
        {
            return this.tipoDePessoa;
        }
    }
}
