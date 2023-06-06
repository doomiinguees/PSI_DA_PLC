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
    public partial class FilmeForm : Form
    {
        ApplicationContext appContext = new ApplicationContext();
        public FilmeForm()
        {
            InitializeComponent();

        }

        private void FilmeForm_Load(object sender, EventArgs e)
        {
            string nome = appContext.Cinemas.First().nome;
            this.Text = $"{nome} | Filmes";

            cbCategoria.Items.Add("Acção");
            cbCategoria.Items.Add("Thriller");
            cbCategoria.Items.Add("Comédia");
            cbCategoria.Items.Add("Ficção Cientifica");
            cbCategoria.Items.Add("Drama");

            cbStatus.Items.Add("Ativo");
            cbStatus.Items.Add("Inativo");

            UpdateList();
            ClearInputs();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            int select = lbFilme.SelectedIndex;

            if (select == -1)
            {
                Filme filme = new Filme();
                string nome = tbNomeFilme.Text;
                string categoria = cbCategoria.Text;
                string estado = cbStatus.Text;
                DateTime tempo = duracaoFilme.Value;
                int horas = tempo.Hour;
                int minutos = tempo.Minute;
                int segundos = tempo.Second;

                TimeSpan duracao = new TimeSpan(horas, minutos, segundos);


                if (ConfirmaString(nome, "Nome") == true || ConfirmaString(categoria, "Categoria") == true || ConfirmaString(estado, "estado") == true)
                {
                    return;
                }
                else
                {
                    filme.Nome = nome;
                    filme.Categoria = categoria;
                    filme.Estado = estado;
                    filme.Duracao = duracao;

                    appContext.Filmes.Add(filme);
                    appContext.SaveChanges();
                }
            }
            else
            {
                Filme filme = lbFilme.SelectedItem as Filme;

                string nome = tbNomeFilme.Text;
                string categoria = cbCategoria.Text;
                string estado = cbStatus.Text;
                DateTime tempo = duracaoFilme.Value;
                int horas = tempo.Hour;
                int minutos = tempo.Minute;
                int segundos = tempo.Second;

                TimeSpan duracao = new TimeSpan(horas, minutos, segundos);

                if (ConfirmaString(nome, "Nome") == true || ConfirmaString(categoria, "Categoria") == true || ConfirmaString(estado, "estado") == true)
                {
                    return;
                }
                else
                {
                    filme.Nome = nome;
                    filme.Categoria = categoria;
                    filme.Estado = estado;
                    filme.Duracao = duracao;

                    appContext.Filmes.AddOrUpdate(filme);
                    appContext.SaveChanges();
                }

            }
            UpdateList();
            ClearInputs();

        }

        private void lbNomeFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lbFilme.SelectedIndex;

            if (selected == -1)
            {
                btnAddMovie.Text = "Adicionar Filme";
                ClearInputs();
                return;
            }
            else
            {
                Filme filme = lbFilme.SelectedItem as Filme;
                tbNomeFilme.Text = filme.Nome;
                cbCategoria.Text = filme.Categoria.ToString();
                duracaoFilme.Value = DateTime.Today.Add(filme.Duracao);
                cbStatus.Text = filme.Estado.ToString();
                btnAddMovie.Text = "Atualizar filme";
            }
            

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

        private void UpdateList()
        {
            lbFilme.DataSource = null;
            lbFilme.DataSource = appContext.Filmes.ToList();
        }

        private void ClearInputs()
        {
            tbNomeFilme.Clear();
            cbCategoria.SelectedIndex = -1;
            cbStatus.SelectedIndex = 1;
            lbFilme.SelectedIndex = -1;
            duracaoFilme.Value = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
