using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string nif { get; set; }
        public float total { get; set; }
        public List<Compra> compras = new List<Compra>();
        public Cliente(string nome, string nif)
        {
            this.nome = nome;
            this.nif = nif;
            this.total = 0;
        }

        public Cliente()
        {
            //Bananas
        }

        public override string ToString()
        {
            return $"{nome} ({nif})";
        }
    }
}
