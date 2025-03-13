using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    class Coisa
    {
        private static Random rnd = new Random();
        public string nome;
        public List<int> valores;
        public int totalValores;
        

        public Coisa(string nome)
        {
            this.nome = nome;
            this.valores = new List<int>();
            this.totalValores = 0;
        }

        public void InventarValor()
        {
            int valor = rnd.Next(1, 101);
            this.valores.Add(valor);
            this.totalValores += valor;
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + " -> [" + string.Join(", ", this.valores) + "] = " + this.totalValores;
        }
    }


}
