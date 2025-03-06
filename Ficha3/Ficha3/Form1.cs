using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            DateTime dataNascimento = monthCalendar1.SelectionStart;
            string morada = textBoxMorada.Text;

            Pessoa newPessoa = new Pessoa(nome, dataNascimento, morada);

            listBox1.Items.Add(newPessoa);
        }

        private void buttonPontuar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Pessoa pessoa = (Pessoa)listBox1.SelectedItem;
                pessoa.pontuar(1);
                listBox1.Items[listBox1.SelectedIndex] = pessoa;
            }
        }
    }
}
