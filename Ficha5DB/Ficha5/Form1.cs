using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha5
{
    public partial class Form1: Form
    {
        Ficha5DB db;
        public Form1()
        {
            InitializeComponent();

            db = new Ficha5DB();
            db.Clientes.Load();
            db.Compras.Load();
            db.Linhas.Load();

            listBoxListaClientes.DataSource = db.Clientes.Local.ToBindingList();
            listBoxCompras.DataSource = db.Compras.Local.ToBindingList();
            listBoxLinhaCompras.DataSource = db.Linhas.Local.ToBindingList();

            listBoxCompras.DataSource = null;
            listBoxLinhaCompras.DataSource = null;
        }
        protected override void OnClosing(CancelEventArgs e)
        {       
            db.SaveChanges();
            db.Dispose();
            base.OnClosing(e);
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            if(textBoxNome.Text == "" || textBoxNIF.Text == "")
            {
                MessageBox.Show("Preencha os campos Nome e NIF!");
                return;
            }
            //if (!verificaNif(textBoxNIF.Text))
            //{
            //    MessageBox.Show("NIF Inválido!");
            //    return;
            //}
            Cliente cliente = new Cliente(textBoxNome.Text, textBoxNIF.Text);

            db.Clientes.Add(cliente);
        }

        private void listBoxListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxListaClientes.SelectedItem as Cliente;

            if (cliente != null && listBoxListaClientes.SelectedIndex != -1)
            {
                labelNomeCliente.Text = cliente.nome;
                labelNIF.Text = cliente.nif;
                labelTotal.Text = cliente.total.ToString() + "€";

                db.SaveChanges();

                listBoxCompras.DataSource = null;
                listBoxCompras.DataSource = db.Compras
                    .Where(c => c.cliente.id == cliente.id).ToList();

                listBoxCompras.DataSource = null;
                listBoxCompras.DataSource = db.Compras
                    .Where(c => c.cliente.id == cliente.id).ToList();
            }
        }
        private void listBoxCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Compra compra = (Compra)listBoxCompras.SelectedItem;

            if (compra != null)
            {
                listBoxLinhaCompras.DataSource = null;
                listBoxLinhaCompras.DataSource = db.Linhas
                    .Where(c => c.compra.id == compra.id).ToList();

                labelTotalLinha.Text = compra.totalCompras.ToString();
            }
        }
        private void buttonCriarCompra_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxListaClientes.SelectedItem;
            if (cliente == null)
            {
                MessageBox.Show("Boom!");
                return;
            }
            Compra compra = new Compra(cliente.nome, cliente.nif, 0);
            compra.cliente = cliente;

            db.Compras.Add(compra);
            db.SaveChanges();

            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = db.Compras
                .Where(c => c.cliente.id == cliente.id).ToList();

            listBoxLinhaCompras.DataSource = null;
            listBoxLinhaCompras.DataSource = db.Linhas
                .Where(l => l.compra.id == compra.id).ToList();

            listBoxListaClientes.DataSource = null;
            listBoxListaClientes.DataSource = db.Clientes.Local.ToBindingList();
        }
        private void buttonApagarCompra_Click(object sender, EventArgs e)
        {
            Compra compra = (Compra)listBoxCompras.SelectedItem;
            Cliente cliente = (Cliente)listBoxListaClientes.SelectedItem;

            if (compra == null)
            {
                MessageBox.Show("Selecione uma compra para apagar!");
                return;
            }
            if (cliente == null)
            {
                MessageBox.Show("Selecione um cliente!");
                return;
            }

            cliente.total -= compra.totalCompras;

            db.Compras.Remove(compra);
            db.SaveChanges();

            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = db.Compras
                .Where(c => c.cliente.id == cliente.id).ToList();

            listBoxLinhaCompras.DataSource = null;
            listBoxLinhaCompras.DataSource = db.Linhas
                .Where(l => l.compra.id == compra.id).ToList();

            listBoxListaClientes.DataSource = null;
            listBoxListaClientes.DataSource = db.Clientes.Local.ToBindingList();
        }
        private void buttonAdicionarLinha_Click(object sender, EventArgs e)
        {
            int indexTemp = listBoxCompras.SelectedIndex;

            Compra compra = (Compra)listBoxCompras.SelectedItem;
            Cliente cliente = (Cliente)listBoxListaClientes.SelectedItem;

            if (textBoxDescricao.Text == "" || textBoxValor.Text == "")
            {
                MessageBox.Show("Preencha os campos Descrição e Valor!");
                return;
            }
            if (compra == null)
            {
                MessageBox.Show("Selecione uma compra!");
                return;
            }
            float checkNumber;
            if(!float.TryParse((textBoxValor.Text), out checkNumber)){
                MessageBox.Show("O valor do produto não é válido");
                return;
            }
            Linha linha = new Linha(textBoxDescricao.Text, float.Parse(textBoxValor.Text));
            linha.compra = compra;
            
            compra.totalCompras += linha.valor;
            cliente.total += linha.valor;

            db.Linhas.Add(linha);
            db.SaveChanges();

            labelTotalLinha.Text = compra.totalCompras.ToString();

            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = db.Compras
                .Where(c => c.cliente.id == cliente.id).ToList();

            listBoxLinhaCompras.DataSource = null;
            listBoxLinhaCompras.DataSource = db.Linhas
                .Where(l => l.compra.id == compra.id).ToList();

            listBoxListaClientes.DataSource = null;
            listBoxListaClientes.DataSource = db.Clientes.Local.ToBindingList();

            listBoxCompras.SelectedIndex = indexTemp;
        }



        private void buttonApagarLinha_Click(object sender, EventArgs e)
        {
            int indexTemp = listBoxCompras.SelectedIndex;

            Linha linha = (Linha)listBoxLinhaCompras.SelectedItem;
            Cliente cliente = (Cliente)listBoxListaClientes.SelectedItem;
            Compra compra = (Compra)listBoxCompras.SelectedItem;
            
            if (linha == null)
            {
                MessageBox.Show("Selecione uma linha para apagar!");
                return;
            }
            compra.totalCompras -= linha.valor;
            cliente.total -= linha.valor;


            db.Linhas.Remove(linha);
            db.SaveChanges();


            listBoxCompras.SelectedIndex = indexTemp;

            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = db.Compras
                .Where(c => c.cliente.id == cliente.id).ToList();

            listBoxLinhaCompras.DataSource = null;
            listBoxLinhaCompras.DataSource = db.Linhas
                .Where(l => l.compra.id == compra.id).ToList();

            listBoxListaClientes.DataSource = null;
            listBoxListaClientes.DataSource = db.Clientes.Local.ToBindingList();

            labelTotalLinha.Text = compra.totalCompras.ToString();
        }



        public bool verificaNif(string nif)
        {
            if (string.IsNullOrWhiteSpace(nif) || nif.Length != 9 || !nif.All(char.IsDigit))
                return false;

            int[] validFirstDigits = { 1, 2, 5, 6, 7, 8, 9 }; // Prefixos válidos para NIFs comuns
            if (!validFirstDigits.Contains(nif[0] - '0'))
                return false;

            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                sum += (nif[i] - '0') * (9 - i);
            }

            int checkDigit = 11 - (sum % 11);
            if (checkDigit >= 10) checkDigit = 0;

            return checkDigit == (nif[8] - '0');
        }
    }
}
