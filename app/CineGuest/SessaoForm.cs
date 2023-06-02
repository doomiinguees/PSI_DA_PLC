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
    public partial class SessaoForm : Form
    {
        private ApplicationContext appContext = new ApplicationContext();
        public SessaoForm()
        {
            InitializeComponent();

        }

        private void btnAddSessao_Click(object sender, EventArgs e)
        {
            Sessao sessao = new Sessao();
            string sala = cbSala.Text.ToString();
            string filme = cbFilme.Text.ToString();
            string precostr = tbPrecoSessao.Text /*+ ""*/;
            DateTime hora = new DateTime(hrSessao.Value.Hour, hrSessao.Value.Minute, 0);
            DateTime inicio = dtaInicioSessao.Value.Date;
            DateTime fim = dtaFimSessao.Value.Date;

            if (confirmaString(sala, "Sala") == true || confirmaString(filme, "Filme") == true || confirmaString(precostr, "Preço") == true)
            {
                return;
            }
            else
            {
                label1.Text = inicio.ToString();
                float preco = float.Parse(precostr);

                for (DateTime item = inicio;  item <= fim; item.AddDays(1))
                {
                    sessao.Salas = sala;
                    sessao.Filmes = filme;
                    sessao.Preco = preco;
                    sessao.Data = item;
                 /*   sessao.Hora = hora;*/

                    appContext.Sessoes.Add(sessao);
                    appContext.SaveChanges();
                }

                lbSessoes.DataSource = null;
                lbSessoes.DataSource = appContext.Sessoes.ToList();

                clearInputs();

            }
        }

        private void SessaoForm_Load(object sender, EventArgs e)
        {
            foreach (var item in appContext.Salas)
            {
                cbSala.Items.Add(item.nome);
            }

            foreach (var iten in appContext.Filmes)
            {
                cbFilme.Items.Add(iten.Nome);
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

        public void clearInputs()
        {
            cbSala.SelectedIndex = -1;
            cbFilme.SelectedIndex = -1;
            tbPrecoSessao.Clear();
        }
    }
}
