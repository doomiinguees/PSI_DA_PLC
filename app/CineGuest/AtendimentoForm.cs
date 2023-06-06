using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGuest
{
    public partial class AtendimentoForm : Form
    {
        ApplicationContext appContext = new ApplicationContext();
        Bilhete bilhete = null;
        public AtendimentoForm()
        {
            InitializeComponent();
            
        }

        private void AtendimentoForm_Load(object sender, EventArgs e)
        {
            
           /* string nome = appContext.Cinemas.First().nome;
            this.Text = $"{nome} | Venda de Bilhetes";*/
            tabSala.SuspendLayout();
            Sessao sessao = appContext.Sessoes.First(s => s.id == this.bilhete.IdSessao);
            Sala sala = appContext.Salas.First(s => s.nome == sessao.Salas);


            int coluna = sala.colunas;
            int linha = sala.linhas;
            tabSala.ColumnCount = coluna;
            tabSala.RowCount = linha;





            for (int i=0; i < linha; i++)
            {
                for (int j=0; j < coluna; j++)
                {
                    Button butao = new Button();
                    butao.Size = new Size(45, 25);
                    butao.Text = (char)(i + 65) + " | " + (j + 1);
                    tabSala.Controls.Add(butao, j, i);

                    butao.Click += Butao_Click;
                }
            }

            tabSala.ResumeLayout();
            tabSala.AutoScroll = true;
        }

        private void Butao_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Red)
            {
                MessageBox.Show("Ligar já ocupado");
            }
            else
            {
                ((Button)sender).BackColor = Color.Red;
                string but = ((Button)sender).Text;

                lbBancos.Items.Add(but);
            }
        }

        private void btnFinCompra_Click(object sender, EventArgs e)
        {
            //codigo para adicionar à base de dados os bancos ocupados
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();

            cliente.ShowDialog();
        }

        public void MostrarDados(Bilhete bilhete)
        {
            
            Console.WriteLine(bilhete.IdSessao);
            this.bilhete = bilhete;
            ShowDialog();
        }
    }
}

/*
 * busca dados das sessoes e preenche a main

for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Button butao = new Button();
        butao.Size = new Size(40, 25);
        butao.Text = (char)(i + 65) + " | " + (j + 1);
        tabSala.Controls.Add(butao, j, i);

        butao.Click += Butao_Click;
    }
}
*/
