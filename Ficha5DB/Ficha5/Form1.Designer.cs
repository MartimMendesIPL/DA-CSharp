namespace Ficha5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarCliente = new System.Windows.Forms.Button();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxListaClientes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelTotalLinha = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonApagarLinha = new System.Windows.Forms.Button();
            this.buttonApagarCompra = new System.Windows.Forms.Button();
            this.buttonCriarCompra = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxLinhaCompras = new System.Windows.Forms.ListBox();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarLinha = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNIF = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdicionarCliente);
            this.groupBox1.Controls.Add(this.textBoxNIF);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir Cliente";
            // 
            // buttonAdicionarCliente
            // 
            this.buttonAdicionarCliente.Location = new System.Drawing.Point(176, 115);
            this.buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            this.buttonAdicionarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarCliente.TabIndex = 1;
            this.buttonAdicionarCliente.Text = "Adicionar";
            this.buttonAdicionarCliente.UseVisualStyleBackColor = true;
            this.buttonAdicionarCliente.Click += new System.EventHandler(this.buttonAdicionarCliente_Click);
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(87, 87);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(164, 22);
            this.textBoxNIF.TabIndex = 4;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(87, 42);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(164, 22);
            this.textBoxNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxListaClientes);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 359);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes";
            // 
            // listBoxListaClientes
            // 
            this.listBoxListaClientes.FormattingEnabled = true;
            this.listBoxListaClientes.ItemHeight = 16;
            this.listBoxListaClientes.Location = new System.Drawing.Point(6, 21);
            this.listBoxListaClientes.Name = "listBoxListaClientes";
            this.listBoxListaClientes.Size = new System.Drawing.Size(260, 324);
            this.listBoxListaClientes.TabIndex = 6;
            this.listBoxListaClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxListaClientes_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.labelTotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelNIF);
            this.groupBox3.Controls.Add(this.labelNomeCliente);
            this.groupBox3.Location = new System.Drawing.Point(290, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 537);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelTotalLinha);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.buttonApagarLinha);
            this.groupBox4.Controls.Add(this.buttonApagarCompra);
            this.groupBox4.Controls.Add(this.buttonCriarCompra);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.listBoxLinhaCompras);
            this.groupBox4.Controls.Add(this.listBoxCompras);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(23, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(699, 396);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compras";
            // 
            // labelTotalLinha
            // 
            this.labelTotalLinha.AutoSize = true;
            this.labelTotalLinha.Location = new System.Drawing.Point(316, 346);
            this.labelTotalLinha.Name = "labelTotalLinha";
            this.labelTotalLinha.Size = new System.Drawing.Size(31, 16);
            this.labelTotalLinha.TabIndex = 14;
            this.labelTotalLinha.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total:";
            // 
            // buttonApagarLinha
            // 
            this.buttonApagarLinha.Location = new System.Drawing.Point(391, 349);
            this.buttonApagarLinha.Name = "buttonApagarLinha";
            this.buttonApagarLinha.Size = new System.Drawing.Size(93, 23);
            this.buttonApagarLinha.TabIndex = 12;
            this.buttonApagarLinha.Text = "Apagar";
            this.buttonApagarLinha.UseVisualStyleBackColor = true;
            this.buttonApagarLinha.Click += new System.EventHandler(this.buttonApagarLinha_Click);
            // 
            // buttonApagarCompra
            // 
            this.buttonApagarCompra.Location = new System.Drawing.Point(157, 349);
            this.buttonApagarCompra.Name = "buttonApagarCompra";
            this.buttonApagarCompra.Size = new System.Drawing.Size(96, 23);
            this.buttonApagarCompra.TabIndex = 11;
            this.buttonApagarCompra.Text = "Apagar";
            this.buttonApagarCompra.UseVisualStyleBackColor = true;
            this.buttonApagarCompra.Click += new System.EventHandler(this.buttonApagarCompra_Click);
            // 
            // buttonCriarCompra
            // 
            this.buttonCriarCompra.Location = new System.Drawing.Point(27, 349);
            this.buttonCriarCompra.Name = "buttonCriarCompra";
            this.buttonCriarCompra.Size = new System.Drawing.Size(97, 23);
            this.buttonCriarCompra.TabIndex = 9;
            this.buttonCriarCompra.Text = "Criar Compra";
            this.buttonCriarCompra.UseVisualStyleBackColor = true;
            this.buttonCriarCompra.Click += new System.EventHandler(this.buttonCriarCompra_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Linha de Compras:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Compras:";
            // 
            // listBoxLinhaCompras
            // 
            this.listBoxLinhaCompras.FormattingEnabled = true;
            this.listBoxLinhaCompras.ItemHeight = 16;
            this.listBoxLinhaCompras.Location = new System.Drawing.Point(269, 51);
            this.listBoxLinhaCompras.Name = "listBoxLinhaCompras";
            this.listBoxLinhaCompras.Size = new System.Drawing.Size(215, 292);
            this.listBoxLinhaCompras.TabIndex = 8;
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.ItemHeight = 16;
            this.listBoxCompras.Location = new System.Drawing.Point(27, 51);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(226, 292);
            this.listBoxCompras.TabIndex = 7;
            this.listBoxCompras.SelectedIndexChanged += new System.EventHandler(this.listBoxCompras_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonAdicionarLinha);
            this.groupBox5.Controls.Add(this.textBoxValor);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBoxDescricao);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(490, 51);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 288);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adicionar Linha de Compra";
            // 
            // buttonAdicionarLinha
            // 
            this.buttonAdicionarLinha.Location = new System.Drawing.Point(9, 237);
            this.buttonAdicionarLinha.Name = "buttonAdicionarLinha";
            this.buttonAdicionarLinha.Size = new System.Drawing.Size(175, 23);
            this.buttonAdicionarLinha.TabIndex = 5;
            this.buttonAdicionarLinha.Text = "Adicionar Linha";
            this.buttonAdicionarLinha.UseVisualStyleBackColor = true;
            this.buttonAdicionarLinha.Click += new System.EventHandler(this.buttonAdicionarLinha_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(9, 143);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(175, 22);
            this.textBoxValor.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(9, 60);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(175, 22);
            this.textBoxDescricao.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descrição";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(656, 45);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(49, 20);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "00,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total:";
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(23, 66);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(70, 16);
            this.labelNIF.TabIndex = 1;
            this.labelNIF.Text = "543543543";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(18, 33);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(244, 29);
            this.labelNomeCliente.TabIndex = 0;
            this.labelNomeCliente.Text = "NOME NOME NOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdicionarCliente;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxListaClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdicionarLinha;
        private System.Windows.Forms.ListBox listBoxLinhaCompras;
        private System.Windows.Forms.ListBox listBoxCompras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonApagarCompra;
        private System.Windows.Forms.Button buttonCriarCompra;
        private System.Windows.Forms.Label labelTotalLinha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonApagarLinha;
    }
}

