using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5
{
    class Cliente
    {
        public string nome { get; }
        public string nif { get; }
        public float total { get; set; }
        public List<Compra> compras { get; set; }
        public Cliente(string nome, string nif)
        {
            this.nome = nome;
            this.nif = nif;
            this.total = 0;
            this.compras = new List<Compra>();
        }

        public override string ToString()
        {
            return $"{nome} ({nif})";
        }
    }
}
