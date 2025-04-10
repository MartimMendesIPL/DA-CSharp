using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5
{
    class Compra
    {
        public DateTime data { get; }
        public float totalCompras { get; set; }
        public List<Linha> linhas { get; set; }
        public Compra(string nome, string nif, float total)
        {
            this.data = DateTime.Now;
            this.totalCompras = total;
            this.linhas = new List<Linha>();
        }

        public override string ToString()
        {
            return this.data.ToString() + " | " + this.totalCompras + "€";
        }
    }
}
