using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5
{
    public class Compra
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public float totalCompras { get; set; }
        public Cliente cliente { get; set; }
        public List<Linha> linhas = new List<Linha>();
        public Compra(string nome, string nif, float total)
        {
            this.data = DateTime.Now;
            this.totalCompras = total;
        }

        public Compra()
        {
            //Bananas
        }

        public override string ToString()
        {
            return this.data.ToString() + " | " + this.totalCompras + "€";
        }
    }
}
