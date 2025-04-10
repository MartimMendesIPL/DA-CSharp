using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha9
{
    public class OficinaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Parcela> Parcelas { get; set; }
    }
}
