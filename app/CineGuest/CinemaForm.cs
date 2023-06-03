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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CineGuest
{
    public partial class CinemaForm : Form
    {
        private ApplicationContext appContext = new ApplicationContext();

        public CinemaForm()
        {
            InitializeComponent();

            bool exist_cinema = appContext.Cinemas.Count() > 0;

            if (!exist_cinema)
            {

                btnUpdateCinema.Text = "Criar Cinema";

            }
            else
            {
                Cinema cinema = appContext.Cinemas.ToList().First();

                tbNomeCinema.Text = cinema.nome;
                tbMoradalCinema.Text = cinema.morada;
                tbEmailCinema.Text = cinema.email;
                btnUpdateCinema.Text = "Atualizar";
            }

            lbSala.SelectedIndex = -1;
            updateListBox();
            ClearLabels();
        }

        private void CinemaForm_Load(object sender, EventArgs e)
        {
            string nome = appContext.Cinemas.First().nome;
            this.Text = $"{nome} | Cinema";
            updateListBox();
            ClearLabels();
        }

        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            string nome = tbNomeCinema.Text;
            string morada = tbMoradalCinema.Text;
            string email = tbEmailCinema.Text;

            if(ConfirmaString(nome, "Nome") == true || ConfirmaEmail(email, "Email") == true || ConfirmaString(morada, "Morada"))
            {
                return;
            }
            
            bool exist_cinema = appContext.Cinemas.Count() > 0;

            if (!exist_cinema)
            {
                Cinema cinema = new Cinema(); 

                cinema.nome = nome;
                cinema.morada = morada;
                cinema.email = email;

                btnUpdateCinema.Text = "Criar Cinema";
                appContext.Cinemas.Add(cinema);

            }
            else
            {
                Cinema cine = appContext.Cinemas.ToList().First();

                cine.nome = nome;
                cine.morada = morada;
                cine.email = email;
                appContext.Cinemas.AddOrUpdate(cine);
            }

            appContext.SaveChanges();
            btnUpdateCinema.Text = "Atualizar";


        }

        private void btnAddSala_Click(object sender, EventArgs e)
        {
            //add db
            
            int select = lbSala.SelectedIndex;
            if (select == -1)
            {
                btnAddSala.Text = "Adicionar";
                string nome = tbNomeSala.Text;
                string colunas = tbColunasSala.Text;
                string linhas = tbLinhasSala.Text;

                if (ConfirmaString(nome, "Sala") == true || ConfirmaInt(colunas, "Número de colunas") == true || ConfirmaInt(linhas, "Número de linhas"))
                {
                    return;
                }
                else
                {
                    int col = int.Parse(colunas);
                    int lin = int.Parse(linhas);

                    Sala sala = new Sala();
                    sala.nome = nome;
                    sala.colunas = col;
                    sala.linhas = lin;

                    appContext.Salas.Add(sala);
                    appContext.SaveChanges();
                }
            }
            else
            {
                string nome = tbNomeSala.Text;
                string colunas = tbColunasSala.Text;
                string linhas = tbLinhasSala.Text;

                if (ConfirmaString(nome, "Sala") == true || ConfirmaInt(colunas, "Número de colunas") == true || ConfirmaInt(linhas, "Número de linhas"))
                {
                    return;
                }
                else
                {
                    int col = int.Parse(colunas);
                    int lin = int.Parse(linhas);

                    Sala sala = lbSala.SelectedItem as Sala;
                    sala.nome = nome;
                    sala.colunas = col;
                    sala.linhas = lin;

                    appContext.Salas.AddOrUpdate(sala);
                    appContext.SaveChanges();
                }
                updateListBox();
                ClearLabels();
                lbSala.SelectedIndex = -1;
            }

            updateListBox();
            ClearLabels();
            lbSala.SelectedIndex = -1;

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
                Sala sala = appContext.Salas.ToList()[select];
                appContext.Salas.Remove(sala);
                appContext.SaveChanges();

                updateListBox();
                ClearLabels();
            }
        }

        private void ClearLabels()
        {
            lbSala.SelectedIndex= -1;
            tbNomeSala.Clear();
            tbColunasSala.Clear();
            tbLinhasSala.Clear();
        }

        private void updateListBox()
        {
            lbSala.DataSource = null;
            lbSala.DataSource = appContext.Salas.ToList();
        }

        public bool ConfirmaString(string verificar, string dado)
        {
            if (verificar == string.Empty)
            {
                MessageBox.Show($"{dado} inválid@");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConfirmaInt(string verificar, string dado)
        {
            int data;

            if (!int.TryParse(verificar, out data))
            {
                if (data < 0)
                {
                    MessageBox.Show($"{dado} inválid@");

                }
                MessageBox.Show($"{dado} inválid@");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConfirmaEmail(string verificar, string dado)
        {
            string vefifyemail = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (verificar == string.Empty || !Regex.IsMatch(verificar, vefifyemail))
            {
                MessageBox.Show($"{dado} inválido");
                return true;
            }
            else
            {
                return false; 
            }
        }

        private void CinemaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (appContext.Cinemas.Count() == 0)
            {
                MessageBox.Show("Dados do cinema não inseridos");
                return;
            }
        }
    }
}
