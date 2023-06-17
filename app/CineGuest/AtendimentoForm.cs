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
        float total;
        public AtendimentoForm()
        {
            InitializeComponent();
            
        }

        private void AtendimentoForm_Load(object sender, EventArgs e)
        {
            
            tabSala.SuspendLayout();
            Sessao sessao = appContext.Sessoes.First(s => s.id == this.bilhete.IdSessao);
            Sala sala = appContext.Salas.First(s => s.nome == sessao.Salas);

            lblFilme.Text = sessao.Filmes;
            lblSala.Text = sala.nome;
            lblPreco.Text = $"{sessao.Preco}€ por bilhete";

            int coluna = sala.colunas;
            int linha = sala.linhas;
            tabSala.ColumnCount = coluna;
            tabSala.RowCount = linha;

            for (int i=0; i < linha; i++)
            {
                for (int j=0; j < coluna; j++)
                {
                    Button butao = new Button();
                    butao.Size = new Size(60, 30);
                    
                    butao.Text = (char)(i + 65) + " | " + (j + 1);
                    tabSala.Controls.Add(butao, j, i);

                    foreach (var item in appContext.Bilhetes)
                    {
                        if (item.lugar == butao.Text)
                        {
                            butao.BackColor = Color.Red;
                        }
                    }

                    butao.Click += Butao_Click;
                }
            }
            tabSala.ResumeLayout();
            tabSala.AutoScroll = true;
            UpdateCbCliente();
        }

        private void Butao_Click(object sender, EventArgs e)
        {

            if (((Button)sender).BackColor == Color.Red)
            {
                MessageBox.Show("Ligar já ocupado");
                return;
            }
            else
            {
                ((Button)sender).BackColor = Color.Red;
                string but = ((Button)sender).Text;

                lbBancos.Items.Add(but);
                Sessao sessao = appContext.Sessoes.First(s => s.id == this.bilhete.IdSessao);

                total = total + sessao.Preco;
                lblPrice.Text = $"{(float)Math.Round(total, 2)} €";
                Console.WriteLine(total);
            }
        }

        private void btnFinCompra_Click(object sender, EventArgs e)
        {
            foreach (var item in lbBancos.Items)
            {
                bilhete.lugar = item.ToString();
                bilhete.IdCliente = appContext.Clientes.First(c => c.Nome == cbCliente.Text).Id;
                bilhete.estado = "Vendido - Não utilizado";
                
                appContext.Bilhetes.Add(bilhete);
                appContext.SaveChanges();

                MessageBox.Show($"Compra finalizada. Valor a pagar: {total}€");
            }
            
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();

            cliente.ShowDialog();
            UpdateCbCliente();
        }

        public void MostrarDados(Bilhete bilhete)
        {
            
            this.bilhete = bilhete;
            ShowDialog();
        }

        private void UpdateCbCliente()
        {
            foreach (var item in appContext.Clientes)
            {
                cbCliente.Items.Add(item.Nome);
                
            }
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
