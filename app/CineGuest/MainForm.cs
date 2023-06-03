using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace CineGuest
{
    public partial class MainForm : Form
    {
        private ApplicationContext appContext = new ApplicationContext();
        public MainForm()
        {
            InitializeComponent();

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
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            CinemaForm cinemaForm = new CinemaForm();
            cinemaForm.ShowDialog();

        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmeForm filmeForm = new FilmeForm();
            filmeForm.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunconarioForm funconarioForm = new FunconarioForm();
            funconarioForm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.ShowDialog();
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (appContext.Cinemas.Count() == 0)
            {
                CinemaForm cineForm = new CinemaForm();
                cineForm.ShowDialog();
            }
            string nome = appContext.Cinemas.First().nome;
            this.Text = $"{nome}";
            /*
             * pedir ajuda para colocar o nome dos funcionários na combobox
            */


        }

        private void sesõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessaoForm sessaoForm = new SessaoForm();
            sessaoForm.ShowDialog();
        }
    }
}
