using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
                if (iten.Estado == "Ativo")
                {
                    cbFilme.Items.Add(iten.Nome);
                }
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
                DateTime data = dtaSessao.Value.Date;
                DateTime tempo = hrSessao.Value;
                int horas = tempo.Hour;
                int minutos = tempo.Minute;
                int segundos = tempo.Second;

                TimeSpan hora = new TimeSpan(horas, minutos, segundos);



                if (ConfirmaString(sala, "Sala") == true || ConfirmaString(filme, "Filme") == true || ConfirmaFloat(precostr, "Preço") == true)
                {
                    return;
                }
                else
                {
                    Filme film = appContext.Filmes.First(f => f.Nome == filme);

                    foreach (var item in appContext.Sessoes.ToList())
                    {
                        Filme filmReg = appContext.Filmes.First(f => f.Nome == item.Filmes);
                        if (item.Salas == sala && item.Data == data)
                        {
                            if (hora + film.Duracao > item.Hora || hora < item.Hora + filmReg.Duracao)
                            {
                                MessageBox.Show("A sessão não pode ser inserida por sobrepor a outra");
                                return;
                            }
                        }
                    }

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
                DateTime tempo = hrSessao.Value;
                int horas = tempo.Hour;
                int minutos = tempo.Minute;
                int segundos = tempo.Second;

                TimeSpan hora = new TimeSpan(horas, minutos, segundos);
                DateTime data = dtaSessao.Value.Date;

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
                    if (VerificarSobreposicaoFilmesSala(sessao))
                    {

                    }
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
                dtaSessao.Value = sessao.Data;
                hrSessao.Value = DateTime.Today.Add(sessao.Hora);

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
            dtaSessao.Value = DateTime.Now.Date;
            hrSessao.Value = DateTime.Parse(DateTime.Now.ToString("HH:mm"));
        }

       private bool VerificarSobreposicaoFilmesSala(Sessao novaSessao)
        {

            List<Sessao> sessoesExistentes = appContext.Sessoes.ToList();

            Filme filme = appContext.Filmes.FirstOrDefault(f => f.Nome == novaSessao.Filmes);

            foreach (Sessao sessaoExistente in sessoesExistentes)
            {
                // Verifica se as salas são iguais
                if (sessaoExistente.Salas == novaSessao.Salas)
                {
                    // Verifica se há sobreposição de horários
                    DateTime inicioExistente = sessaoExistente.Data + sessaoExistente.Hora;
                    DateTime fimExistente = inicioExistente + appContext.Filmes.Where( f => f.Nome.ToLower() == sessaoExistente.Filmes.ToLower()).First().Duracao;

                    DateTime inicioNova = novaSessao.Data + novaSessao.Hora;
                    DateTime fimNova = inicioNova + appContext.Filmes.Where(f => f.Nome.ToLower() == novaSessao.Filmes.ToLower()).First().Duracao;

                    if (inicioNova < fimExistente && fimNova > inicioExistente)
                    {
                        // Há sobreposição de horários, não é permitido criar a sessão
                        return false;
                    }
                }
            }

            // Não há sobreposição de horários, a criação da sessão é permitida
            return true;
        }
    }
}
