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
    public partial class CinemaForm : Form
    {
        public CinemaForm()
        {
            InitializeComponent();

            tbNomeCinema.Text = /*nome cinema bd*/ "Nome conema";
            tbMoradalCinema.Text = /*morada cinema bd*/ "morada conema";
            tbEmailCinema.Text = /*email cinema bd*/ "email conema";
        }

        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            int select = lbNome.SelectedIndex;
            string nome = tbNomeSala.Text;
            string colunas = tbColunasSala.Text;
            string linhas = tbLinhasSala.Text;

            lbNome.Items[select] = nome;
            lbColuna.Items[select] = colunas;
            lbLinha.Items[select] = linhas;
            //savechanges
        }

        private void btnAddSala_Click(object sender, EventArgs e)
        {
            //add db
            int select = lbNome.SelectedIndex;
            if (select == -1)
            {
                btnAddSala.Text = "Adicionar";
                string nome = tbNomeSala.Text;
                string colunas = tbColunasSala.Text;
                string linhas = tbLinhasSala.Text;

                lbNome.Items.Add(nome);
                lbColuna.Items.Add(colunas);
                lbLinha.Items.Add(linhas);

                ClearLabels();
            }
            else
            {
                btnAddSala.Text = "Alterar";
                string nome = tbNomeSala.Text;
                string colunas = tbColunasSala.Text;
                string linhas = tbLinhasSala.Text;

                lbNome.Items[select] = nome;
                lbColuna.Items[select] = colunas;
                lbLinha.Items[select] = linhas;
                lbNome.SelectedIndex = -1;

                btnAddSala.Text = "Adicionaar";
                ClearLabels();
            }
            }
            

        private void lbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = lbNome.SelectedIndex;
            if (select == -1)
            {
                return;
            }
            else
            {
                tbNomeSala.Text = lbNome.Items[select].ToString();
                tbColunasSala.Text = lbColuna.Items[select].ToString();
                tbLinhasSala.Text = lbLinha.Items[select].ToString();

                btnAddSala.Text = "Alterar";
            }
        }

        private void ClearLabels()
        {
            tbNomeSala.Clear();
            tbColunasSala.Clear();
            tbLinhasSala.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int select = lbNome.SelectedIndex;
            if (select == -1)
            {
                return;
            }
            else
            {
                lbNome.Items.RemoveAt(select);
                lbColuna.Items.RemoveAt(select);
                lbLinha.Items.RemoveAt(select);

                ClearLabels();
            }
        }
    }
}
