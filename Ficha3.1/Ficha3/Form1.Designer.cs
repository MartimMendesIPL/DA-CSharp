namespace Ficha3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonAdicionarPessoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonPontuar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNrAluno = new System.Windows.Forms.TextBox();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxDificuldade = new System.Windows.Forms.TextBox();
            this.buttonAdicionarAluno = new System.Windows.Forms.Button();
            this.buttonAdicionarAlunoEsp = new System.Windows.Forms.Button();
            this.buttonAdicionarProfessor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonQuemSou = new System.Windows.Forms.Button();
            this.labelQuem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(40, 51);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(269, 22);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(40, 112);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // buttonAdicionarPessoa
            // 
            this.buttonAdicionarPessoa.Location = new System.Drawing.Point(40, 323);
            this.buttonAdicionarPessoa.Name = "buttonAdicionarPessoa";
            this.buttonAdicionarPessoa.Size = new System.Drawing.Size(269, 23);
            this.buttonAdicionarPessoa.TabIndex = 6;
            this.buttonAdicionarPessoa.Text = "Adicionar Pessoa";
            this.buttonAdicionarPessoa.UseVisualStyleBackColor = true;
            this.buttonAdicionarPessoa.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(350, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 244);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonPontuar
            // 
            this.buttonPontuar.Location = new System.Drawing.Point(350, 301);
            this.buttonPontuar.Name = "buttonPontuar";
            this.buttonPontuar.Size = new System.Drawing.Size(344, 23);
            this.buttonPontuar.TabIndex = 8;
            this.buttonPontuar.Text = "Pontuar";
            this.buttonPontuar.UseVisualStyleBackColor = true;
            this.buttonPontuar.Click += new System.EventHandler(this.buttonPontuar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº Aluno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Curso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Disciplina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dificuldade";
            // 
            // textBoxNrAluno
            // 
            this.textBoxNrAluno.Location = new System.Drawing.Point(116, 409);
            this.textBoxNrAluno.Name = "textBoxNrAluno";
            this.textBoxNrAluno.Size = new System.Drawing.Size(191, 22);
            this.textBoxNrAluno.TabIndex = 13;
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(116, 437);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(191, 22);
            this.textBoxCurso.TabIndex = 14;
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Location = new System.Drawing.Point(116, 464);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(191, 22);
            this.textBoxDisciplina.TabIndex = 15;
            // 
            // textBoxDificuldade
            // 
            this.textBoxDificuldade.Location = new System.Drawing.Point(116, 492);
            this.textBoxDificuldade.Name = "textBoxDificuldade";
            this.textBoxDificuldade.Size = new System.Drawing.Size(191, 22);
            this.textBoxDificuldade.TabIndex = 16;
            // 
            // buttonAdicionarAluno
            // 
            this.buttonAdicionarAluno.Location = new System.Drawing.Point(25, 520);
            this.buttonAdicionarAluno.Name = "buttonAdicionarAluno";
            this.buttonAdicionarAluno.Size = new System.Drawing.Size(94, 63);
            this.buttonAdicionarAluno.TabIndex = 17;
            this.buttonAdicionarAluno.Text = "Adicionar Aluno";
            this.buttonAdicionarAluno.UseVisualStyleBackColor = true;
            this.buttonAdicionarAluno.Click += new System.EventHandler(this.buttonAdicionarAluno_Click);
            // 
            // buttonAdicionarAlunoEsp
            // 
            this.buttonAdicionarAlunoEsp.Location = new System.Drawing.Point(125, 520);
            this.buttonAdicionarAlunoEsp.Name = "buttonAdicionarAlunoEsp";
            this.buttonAdicionarAlunoEsp.Size = new System.Drawing.Size(94, 63);
            this.buttonAdicionarAlunoEsp.TabIndex = 18;
            this.buttonAdicionarAlunoEsp.Text = "Adicionar Aluno Especial";
            this.buttonAdicionarAlunoEsp.UseVisualStyleBackColor = true;
            this.buttonAdicionarAlunoEsp.Click += new System.EventHandler(this.buttonAdicionarAlunoEsp_Click);
            // 
            // buttonAdicionarProfessor
            // 
            this.buttonAdicionarProfessor.Location = new System.Drawing.Point(225, 520);
            this.buttonAdicionarProfessor.Name = "buttonAdicionarProfessor";
            this.buttonAdicionarProfessor.Size = new System.Drawing.Size(94, 63);
            this.buttonAdicionarProfessor.TabIndex = 19;
            this.buttonAdicionarProfessor.Text = "Adicionar Professor";
            this.buttonAdicionarProfessor.UseVisualStyleBackColor = true;
            this.buttonAdicionarProfessor.Click += new System.EventHandler(this.buttonAdicionarProfessor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dados do indíduo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(350, 358);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(344, 161);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // buttonQuemSou
            // 
            this.buttonQuemSou.Location = new System.Drawing.Point(350, 525);
            this.buttonQuemSou.Name = "buttonQuemSou";
            this.buttonQuemSou.Size = new System.Drawing.Size(344, 23);
            this.buttonQuemSou.TabIndex = 22;
            this.buttonQuemSou.Text = "Que Tipo De Pessoa Sou?";
            this.buttonQuemSou.UseVisualStyleBackColor = true;
            this.buttonQuemSou.Click += new System.EventHandler(this.buttonQuemSou_Click);
            // 
            // labelQuem
            // 
            this.labelQuem.AutoSize = true;
            this.labelQuem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuem.Location = new System.Drawing.Point(439, 554);
            this.labelQuem.Name = "labelQuem";
            this.labelQuem.Size = new System.Drawing.Size(164, 29);
            this.labelQuem.TabIndex = 23;
            this.labelQuem.Text = "QUEM SOU?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 597);
            this.Controls.Add(this.labelQuem);
            this.Controls.Add(this.buttonQuemSou);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAdicionarProfessor);
            this.Controls.Add(this.buttonAdicionarAlunoEsp);
            this.Controls.Add(this.buttonAdicionarAluno);
            this.Controls.Add(this.textBoxDificuldade);
            this.Controls.Add(this.textBoxDisciplina);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.textBoxNrAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPontuar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAdicionarPessoa);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonAdicionarPessoa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonPontuar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNrAluno;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.TextBox textBoxDificuldade;
        private System.Windows.Forms.Button buttonAdicionarAluno;
        private System.Windows.Forms.Button buttonAdicionarAlunoEsp;
        private System.Windows.Forms.Button buttonAdicionarProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonQuemSou;
        private System.Windows.Forms.Label labelQuem;
    }
}

