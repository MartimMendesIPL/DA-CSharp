using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha9
{
    public class Servico
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string tipo { get; set; }

        public Carro carro { get; set; }


    }
}
