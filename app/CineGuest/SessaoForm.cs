using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

            UpdateList();
            ClearInputs();
        }

        private void btnAddSessao_Click(object sender, EventArgs e)
        {
            int selected = lbSessoes.SelectedIndex;

            if (selected == -1)
            {
                Sessao sessao = new Sessao();
                string sala = cbSala.Text.ToString();
                string filme = cbFilme.Text.ToString();
                string precostr = tbPrecoSessao.Text;
                string hora = hrSessao.Value.ToString("HH:mm");
                string data = dtaSessao.Value.ToString("dd/MM/yyyy");

                

                if (ConfirmaString(sala, "Sala") == true || ConfirmaString(filme, "Filme") == true || ConfirmaFloat(precostr, "Preço") == true)
                {
                    return;
                }
                else
                {
                    float preco = float.Parse(precostr);

                    sessao.Salas = sala;
                    sessao.Filmes = filme;
                    sessao.Preco = preco;
                    sessao.Data = data;
                    sessao.Hora = hora;

                    appContext.Sessoes.Add(sessao);
                    appContext.SaveChanges();

                }
            }
            else
            {
                Sessao sessao = lbSessoes.SelectedItem as Sessao;

                string sala = cbSala.Text.ToString();
                string filme = cbFilme.Text.ToString();
                string precostr = tbPrecoSessao.Text;
                string hora = hrSessao.Value.ToString("HH:mm");
                string data = dtaSessao.Value.ToString("dd/MM/yyyy");

                if (ConfirmaString(sala, "Sala") == true || ConfirmaString(filme, "Filme") == true || ConfirmaString(precostr, "Preço") == true)
                {
                    return;
                }
                else
                {
                    float preco = float.Parse(precostr);

                    sessao.Salas = sala;
                    sessao.Filmes = filme;
                    sessao.Preco = preco;
                    sessao.Data = data;
                    sessao.Hora = hora;

                    appContext.Sessoes.AddOrUpdate(sessao);
                    appContext.SaveChanges();

                }
            }

            UpdateList();
            ClearInputs();

        }

        private void lbSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lbSessoes.SelectedIndex;
            if (selected == -1)
            {
                btnAddSessao.Text = "Adicionar Sessão";
                ClearInputs();
                return;
            }
            else
            {
                Sessao sessao = lbSessoes.SelectedItem as Sessao;

                //preenchimento de inputs com informação da database
                cbFilme.Text = sessao.Filmes.ToString();
                cbSala.Text = sessao.Salas.ToString();
                tbPrecoSessao.Text = sessao.Preco.ToString();
                dtaSessao.Value = DateTime.Parse(sessao.Data);
                hrSessao.Value = DateTime.Parse(sessao.Hora);

                btnAddSessao.Text = "Atualizar Sessão";

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

        public bool ConfirmaFloat(string verificar, string dado)
        {
            float data;

            if (!float.TryParse(verificar, out data))
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

        public void UpdateList()
        {
            lbSessoes.DataSource = null;
            lbSessoes.DataSource = appContext.Sessoes.ToList();
        }

        public void ClearInputs()
        {
            cbSala.SelectedItem = 0;
            cbFilme.SelectedItem = 0;
            tbPrecoSessao.Clear();
            lbSessoes.SelectedIndex= -1;
            dtaSessao.Value = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
            hrSessao.Value = DateTime.Parse(DateTime.Now.ToString("HH:mm"));
        }

    }
}
