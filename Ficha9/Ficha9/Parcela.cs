﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha9
{
    public class Parcela
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public string descricao { get; set; }

        public Servico servico { get; set; }
    }
}
