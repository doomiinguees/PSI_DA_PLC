using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
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

            bool exist_cinema = applicationContext.cinema.Count() > 0;

            if (!exist_cinema)
            {

                btnUpdateCinema.Text = "Criar Cinema";

            }
            else
            {
                Cinema cinema = applicationContext.cinema.ToList().First();

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
            string nome = tbNomeCinema.Text;
            string morada = tbMoradalCinema.Text;
            string email = tbEmailCinema.Text;

            if(nome == string.Empty || morada == string.Empty || email == string.Empty)
            {
                MessageBox.Show("Existe um campo vazio");
                return;
            }
            else
            {
                bool exist_cinema = applicationContext.cinema.Count() > 0;

                if (!exist_cinema)
                {
                    Cinema cinema = new Cinema(); 

                    cinema.nome = nome;
                    cinema.morada = morada;
                    cinema.email = email;

                    btnUpdateCinema.Text = "Criar Cinema";
                    applicationContext.cinema.Add(cinema);

                }
                else
                {
                    Cinema cine = applicationContext.cinema.ToList().First();

                    cine.nome = nome;
                    cine.morada = morada;
                    cine.email = email;
                    applicationContext.cinema.AddOrUpdate(cine);
                }   
                


                applicationContext.SaveChanges();
                btnUpdateCinema.Text = "Atualizar";
                
            }


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

                applicationContext.sala.Add(sala);
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

                applicationContext.sala.AddOrUpdate(sala);
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
                Sala sala = applicationContext.sala.ToList()[select];
                applicationContext.sala.Remove(sala);
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
            lbSala.DataSource = applicationContext.sala.ToList();
        }

        
    }
}
