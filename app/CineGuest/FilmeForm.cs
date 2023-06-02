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
            cbCategoria.Items.Add("Acção");
            cbCategoria.Items.Add("Thriller");
            cbCategoria.Items.Add("Comédia");
            cbCategoria.Items.Add("Ficção Cientifica");
            cbCategoria.Items.Add("Drama");

            cbStatus.Items.Add("Ativo");
            cbStatus.Items.Add("Inativo");

            lbFilme.SelectedIndex = -1;
            updateList();
            clearInputs();
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
                DateTime duracao = duracaoFilme.Value;

                if (confirmaString(nome, "Nome") == true || confirmaString(categoria, "Categoria") == true || confirmaString(estado, "estado") == true)
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
            else
            {
                Filme filme = lbFilme.SelectedItem as Filme;
                string nome = tbNomeFilme.Text;
                string categoria = cbCategoria.Text;
                string estado = cbStatus.Text;
                DateTime duracao = duracaoFilme.Value;

                if (confirmaString(nome, "Nome") == true || confirmaString(categoria, "Categoria") == true || confirmaString(estado, "estado") == true)
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

            updateList();
            clearInputs();
        }

        private void lbNomeFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lbFilme.SelectedIndex;

            if (selected == -1)
            {
                btnAddMovie.Text = "Adicionar Filme";
                clearInputs();
                return;
            }
            else
            {
                Filme filme = lbFilme.SelectedItem as Filme;
                tbNomeFilme.Text = filme.Nome;
                cbCategoria.Text = filme.Categoria.ToString();
        /*        duracaoFilme.Value = filme.Duracao;*/
                cbStatus.Text = filme.Estado.ToString();

                btnAddMovie.Text = "Atualizar filme";
            }
            

        }

        public bool confirmaString(string verificar, string dado)
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

        private bool confirmaDataHora(DateTime verificar, string dado)
        {
            if (verificar > DateTime.Now)
            {
                MessageBox.Show($"{dado} inválid@");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void updateList()
        {
            lbFilme.DataSource = null;
            lbFilme.DataSource = appContext.Filmes.ToList();
        }

        private void clearInputs()
        {
            lbFilme.SelectedIndex = -1;
            tbNomeFilme.Clear();
            cbCategoria.SelectedIndex = -1;
            cbStatus.SelectedIndex = 1;
        }

        private void FilmeForm_Load(object sender, EventArgs e)
        {
            lbFilme.SelectedIndex = -1;
            updateList();
            clearInputs();
        }
    }
}
