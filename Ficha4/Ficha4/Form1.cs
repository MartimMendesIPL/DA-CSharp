using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha4
{
    public partial class Form1: Form
    {
        private static Random rnd = new Random();
        List<Coisa> coisas = new List<Coisa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBoxAdicionar.Text);
        }

        private void buttonBaralhar_Click(object sender, EventArgs e)
        {
            //Lê o número de ações a realizar
            int numActions = (int)numericUpDown1.Value;

            //Cria um objeto para cada item da listBox1 e guarda os objetos na lista
            if (listBox1.Items.Count > coisas.Count)
            {
                for (int i = coisas.Count; i < listBox1.Items.Count; i++)
                {
                    Coisa coisa = new Coisa(listBox1.Items[i].ToString());
                    coisas.Add(coisa);
                }
            }
            else
            {
                //Baralhar / tentativa de baralhar
                for (int i = 0; i < numActions; i++)
                {
                    foreach (var coisa in coisas)
                    {
                        if (coisa.valores.Count > 1)
                        {
                            int index1 = rnd.Next(coisa.valores.Count);
                            int index2 = rnd.Next(coisa.valores.Count);

                            // Troca os valores dentro do objeto Coisa
                            int temp = coisa.valores[index1];
                            coisa.valores[index1] = coisa.valores[index2];
                            coisa.valores[index2] = temp;
                        }
                    }

                    for(int j = 0; j < coisas.Count; j++)
                    {
                        // Troca os objetos de posição na lista
                        int index1 = rnd.Next(coisas.Count);
                        int index2 = rnd.Next(coisas.Count);
                        Coisa temp = coisas[index1];
                        coisas[index1] = coisas[index2];
                        coisas[index2] = temp;
                    }
                }
            }
            listBox2.DataSource = null;
            listBox2.DataSource = coisas;
            listBox2.DisplayMember = "nome";
        }

        private void buttonAdicionarValor_Click(object sender, EventArgs e)
        {
            if (coisas != null)
            {
                foreach (Coisa coisa in coisas)
                {
                    coisa.InventarValor();
                }
                listBox2.DataSource = null;
                listBox2.DataSource = coisas;
            }

        }
    }
}
