using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGuest
{
    public partial class FilmeForm : Form
    {
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
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string nome = tbNomeFilme.Text;
            string categoria = cbCategoria.Text;
            string estado = cbStatus.Text;

            string concat = $"{nome} | {categoria} | {estado}";

            lbFilme.Items.Add(concat);

            tbNomeFilme.Clear();
            cbCategoria.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
        }

        private void lbNomeFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lbFilme.SelectedIndex;

            string film = lbFilme.Items[selected].ToString();

        }
    }
}
