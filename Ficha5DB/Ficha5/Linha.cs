using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5
{
    public class Linha
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }

        public Compra compra { get; set; }

        public Linha(string descricao, float valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }

        public Linha()
        {
            //Bananas
        }

        public override string ToString()
        {
            return this.valor + "€ " + this.descricao;
        }
    }
}
