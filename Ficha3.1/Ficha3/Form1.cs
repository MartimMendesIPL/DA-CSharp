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

            Pessoa newPessoa = new Pessoa(nome, dataNascimento);

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

        private void buttonAdicionarAluno_Click(object sender, EventArgs e)
        {
            string nrAluno = textBoxNrAluno.Text;
            string curso = textBoxCurso.Text;

            Aluno newAluno = new Aluno(textBoxNome.Text, monthCalendar1.SelectionStart, nrAluno, curso);

            listBox1.Items.Add(newAluno);
        }

        private void buttonAdicionarAlunoEsp_Click(object sender, EventArgs e)
        {
            string dificuldade = textBoxDificuldade.Text;

            AlunoEspecial newAlunoEspecial = new AlunoEspecial(textBoxNome.Text, monthCalendar1.SelectionStart, dificuldade);

            listBox1.Items.Add(newAlunoEspecial);
        }

        private void buttonAdicionarProfessor_Click(object sender, EventArgs e)
        {
            string disciplina = textBoxDisciplina.Text;

            Professor newProfessor = new Professor(textBoxNome.Text, monthCalendar1.SelectionStart, disciplina);

            listBox1.Items.Add(newProfessor);
        }

        private void buttonQuemSou_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Pessoa pessoa = (Pessoa)listBox1.SelectedItem;
                labelQuem.Text = pessoa.queTipoDePessoaSou();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa pessoa = (Pessoa)listBox1.SelectedItem;

            if (pessoa is AlunoEspecial alunoEspecial)
            {
                richTextBox1.Text = alunoEspecial.Mostrar();
            }
            if (pessoa is Professor professor)
            {
                richTextBox1.Text = professor.Mostrar();
            }
            if (pessoa is Aluno aluno)
            {
                richTextBox1.Text = aluno.Mostrar();
            }
        }
    }
}
