using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha5
{
    public partial class Form1: Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            if(textBoxNome.Text == "" || textBoxNIF.Text == "")
            {
                MessageBox.Show("Preencha os campos Nome e NIF!");
                return;
            }
            if (!verificaNif(textBoxNIF.Text))
            {
                MessageBox.Show("NIF Inválido!");
                return;
            }
            Cliente cliente = new Cliente(textBoxNome.Text, textBoxNIF.Text);

            clientes.Add(cliente);
            listBoxListaClientes.DataSource = null;
            listBoxListaClientes.DataSource = clientes;
        }

        private void listBoxListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxListaClientes.SelectedItem as Cliente;

            if (cliente != null)
            {
                labelNomeCliente.Text = cliente.nome;
                labelNIF.Text = cliente.nif;
                labelTotal.Text = cliente.total.ToString() + "€";

                listBoxCompras.DataSource = null;
                listBoxCompras.DataSource = cliente.compras;
                listBoxLinhaCompras.DataSource = null;
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

            cliente.compras.Add(compra);
            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = cliente.compras;

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

            compra.linhas.Add(linha);
            compra.totalCompras += linha.valor;

            cliente.total += linha.valor;

            listBoxLinhaCompras.DataSource = null;
            listBoxLinhaCompras.DataSource = compra.linhas;

            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = cliente.compras;

            listBoxListaClientes.DataSource = null;
            listBoxListaClientes.DataSource = clientes;

            labelTotalLinha.Text = compra.totalCompras.ToString();
            
            listBoxCompras.SelectedIndex = indexTemp;
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

            cliente.total -= compra.totalCompras;
            cliente.compras.Remove(compra);
            
            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = cliente.compras;
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


            compra.linhas.Remove(linha);

            listBoxLinhaCompras.DataSource = null;
            listBoxLinhaCompras.DataSource = compra.linhas;
            listBoxCompras.DataSource = null;
            listBoxCompras.DataSource = cliente.compras;
            listBoxListaClientes.DataSource = null;
            listBoxListaClientes.DataSource = clientes;

            listBoxCompras.SelectedIndex = indexTemp;

            labelTotalLinha.Text = compra.totalCompras.ToString();
        }

        private void listBoxCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Compra compra = (Compra)listBoxCompras.SelectedItem;

            if (compra != null) 
            {
                listBoxLinhaCompras.DataSource = null;
                listBoxLinhaCompras.DataSource = compra.linhas;
            }
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
