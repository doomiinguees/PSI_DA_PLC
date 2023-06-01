using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGuest
{
    public partial class CinemaForm : Form
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        public CinemaForm()
        {
            InitializeComponent();

            bool exist_cinema = applicationContext.Cinemas.Count() > 0;

            if (!exist_cinema)
            {

                btnUpdateCinema.Text = "Criar Cinema";

            }
            else
            {
                Cinema cinema = applicationContext.Cinemas.ToList().First();

                tbNomeCinema.Text = cinema.nome;
                tbMoradalCinema.Text = cinema.morada;
                tbEmailCinema.Text = cinema.email;
                btnUpdateCinema.Text = "Atualizar";
            }

            lbSala.SelectedIndex = -1;
            updateListBox();
            ClearLabels();
        }

        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            string vefifyemail = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string nome = tbNomeCinema.Text;
            string morada = tbMoradalCinema.Text;
            string email = tbEmailCinema.Text;

            if(nome == string.Empty)
            {
                MessageBox.Show("Nome inválida");
                return;
            }

            if (email == string.Empty || !Regex.IsMatch(email, vefifyemail))
            {
                MessageBox.Show("Email inválido");
                return;
            }

            if (morada == string.Empty)
            {
                MessageBox.Show("Morada inválido");
                return;
            }
            
            bool exist_cinema = applicationContext.Cinemas.Count() > 0;

            if (!exist_cinema)
            {
                Cinema cinema = new Cinema(); 

                cinema.nome = nome;
                cinema.morada = morada;
                cinema.email = email;

                btnUpdateCinema.Text = "Criar Cinema";
                applicationContext.Cinemas.Add(cinema);

            }
            else
            {
                Cinema cine = applicationContext.Cinemas.ToList().First();

                cine.nome = nome;
                cine.morada = morada;
                cine.email = email;
                applicationContext.Cinemas.AddOrUpdate(cine);
            }

            applicationContext.SaveChanges();
            btnUpdateCinema.Text = "Atualizar";


        }
        private void btnGoApp_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();

            mainForm.ShowDialog();
        }

        private void btnAddSala_Click(object sender, EventArgs e)
        {
            //add db
            
            int select = lbSala.SelectedIndex;
            if (select == -1)
            {
                btnAddSala.Text = "Adicionar";
                string nome = tbNomeSala.Text;
                int colunas = int.Parse(tbColunasSala.Text);
                int linhas = int.Parse(tbLinhasSala.Text);
                
                Sala sala = new Sala();
                sala.nome = nome;
                sala.colunas = colunas;
                sala.linhas = linhas;

                ApplicationContext applicationContext = new ApplicationContext();

                applicationContext.Salas.Add(sala);
                applicationContext.SaveChanges();
                updateListBox();
                ClearLabels();


            }
            else
            {
                string nome = tbNomeSala.Text;
                int colunas = int.Parse(tbColunasSala.Text);
                int linhas = int.Parse(tbLinhasSala.Text);
                
                Sala sala = lbSala.SelectedItem as Sala;

                sala.nome = nome;
                sala.colunas = colunas;
                sala.linhas = linhas;


                ApplicationContext applicationContext = new ApplicationContext();

                applicationContext.Salas.AddOrUpdate(sala);
                applicationContext.SaveChanges();
                updateListBox();
                ClearLabels();
            }

        }
            

        private void lbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = lbSala.SelectedIndex;
            if (select == -1)
            {
                btnAddSala.Text = "Adicionar Sala";
                return;
            }
            else
            {
                Sala sala = lbSala.SelectedItem as Sala;

                tbNomeSala.Text = sala.nome;
                tbColunasSala.Text = sala.colunas + "";
                tbLinhasSala.Text = sala.linhas + "";

                btnAddSala.Text = "Alterar";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int select = lbSala.SelectedIndex;
            if (select == -1)
            {
                return;
            }
            else
            {
                Sala sala = applicationContext.Salas.ToList()[select];
                applicationContext.Salas.Remove(sala);
                applicationContext.SaveChanges();

                updateListBox();
                ClearLabels();
            }
        }

        private void ClearLabels()
        {
            tbNomeSala.Clear();
            tbColunasSala.Clear();
            tbLinhasSala.Clear();
        }

        private void updateListBox()
        {
            lbSala.DataSource = null;
            lbSala.DataSource = applicationContext.Salas.ToList();
        }

        private void CinemaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (applicationContext.Cinemas.Count() == 0)
            {
                MessageBox.Show("Dados do cinema não inseridos");
                return;
            }
        }

    }
}
