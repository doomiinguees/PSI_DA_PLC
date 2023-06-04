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

            //Verificação de cinema criado.
            //Caso exista, os dados guardados são expostos nas texts box referentes aos dados do cinema e o texto do butão é alterado.
            //Caso não exista, o texto do botão fica normal()embora forçado e o user tem de preencer os dados
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

            //Limpeza de labels e atualização da lista de salas
            updateListBox();
            ClearLabels();
        }

        private void CinemaForm_Load(object sender, EventArgs e)
        {
            bool exist_cinema = appContext.Cinemas.Count() > 0;

            if (exist_cinema)
            {
                //Colocação do nome do cinema no nome do form
                string nome = appContext.Cinemas.First().nome;
                this.Text = $"{nome} | Cinema";
            }
            
            updateListBox();
            ClearLabels();
        }

        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            //Leitura de dados inseridos
            string nome = tbNomeCinema.Text;
            string morada = tbMoradalCinema.Text;
            string email = tbEmailCinema.Text;

            //verificação de dados
            if(ConfirmaString(nome, "Nome") == true || ConfirmaEmail(email, "Email") == true || ConfirmaString(morada, "Morada"))
            {
                return;
            }
            
            //verificação de existencia de cinema
            bool exist_cinema = appContext.Cinemas.Count() > 0;

            //Adição de dados do cinema na base de dades
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
            //Guardar base de dados
            appContext.SaveChanges();
            btnUpdateCinema.Text = "Atualizar";


        }

        private void btnAddSala_Click(object sender, EventArgs e)
        {
            
            //leitura de index selecionado na list box
            int select = lbSala.SelectedIndex;
            //se null, adiciona nova sala
            if (select == -1)
            {
                //Leitura de dados inseridos
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
            //se valido, atualiza dados do index selecionados
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
            //Leitura e verificação de index selecionado na list box
            int select = lbSala.SelectedIndex;
            if (select == -1)
            {
                btnAddSala.Text = "Adicionar Sala";
                return;
            }
            else
            {
                Sala sala = lbSala.SelectedItem as Sala;
                //Coloccação dos dados selecionados nos input boxs
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
                //remove de ocorrencia da base de dados
                Sala sala = appContext.Salas.ToList()[select];
                appContext.Salas.Remove(sala);
                appContext.SaveChanges();

                updateListBox();
                ClearLabels();
            }
        }

        private void ClearLabels()
        {
            //limpeza de input boxs
            lbSala.SelectedIndex= -1;
            tbNomeSala.Clear();
            tbColunasSala.Clear();
            tbLinhasSala.Clear();
        }

        private void updateListBox()
        {
            //Atualização da ListBox
            lbSala.DataSource = null;
            lbSala.DataSource = appContext.Salas.ToList();
        }

        //Confirmaçãoo de string
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

        //Confirmação de inteiros
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

        //Confirmação de email
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

        //Confirmação se dados foram inseridos
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
