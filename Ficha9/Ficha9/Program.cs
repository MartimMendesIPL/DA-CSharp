using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha9
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            using (var db = new OficinaContext())
            {
                var cliente = new Cliente { nome = "Cliente1", nif = "123456789" };
                db.Clientes.Add(cliente);
                var carro = new Carro { matricula = "AA-01-AA", cliente = cliente };
                db.Carro.Add(carro);
                var servico = new Servico { data = DateTime.Now, tipo = "Mudança de óleo", carro = carro };
                db.Servicos.Add(servico);
                var servico2 = new Servico { data = DateTime.Now, tipo = "Mudança de distribuição", carro = carro };
                db.Servicos.Add(servico2);

                var parcela1 = new Parcela { valor = 100, descricao = "Parcela 1", servico = servico };
                db.Parcelas.Add(parcela1);
                var parcela2 = new Parcela { valor = 100, descricao = "Parcela 2", servico = servico };
                db.Parcelas.Add(parcela2);

                var parcela3 = new Parcela { valor = 100, descricao = "Parcela 3", servico = servico2 };
                db.Parcelas.Add(parcela3);
                var parcela4 = new Parcela { valor = 100, descricao = "Parcela 4", servico = servico2 };
                db.Parcelas.Add(parcela4);
                db.SaveChanges();

            }   
        }
    }
}
