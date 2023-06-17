using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace CineGuest
{
    public partial class MainForm : Form
    {
        private ApplicationContext appContext = new ApplicationContext();
        public MainForm()
        {
            InitializeComponent();

            

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (appContext.Cinemas.Count() == 0)
            {
                CinemaForm cineForm = new CinemaForm();
                cineForm.ShowDialog();
            }

            string nome = appContext.Cinemas.First().nome;
            this.Text = $"{nome}";

            DateTime dataAtual = dtpDiadeSessao.Value;
            
            List<Sessao> sessoes = appContext.Sessoes.ToList();

            Console.WriteLine(sessoes.Count());

            lbSessoesMain.Items.Clear();

            foreach (Sessao sessao in sessoes)
            {
                if(dataAtual.Date == sessao.Data.Date)
                {
                    lbSessoesMain.Items.Add(sessao);
                }
            }

            List<Funcionario> funcionarios = appContext.Funcionarios.ToList();

            UpdateUser();
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string funcionario = cbUser.Text;
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            CinemaForm cinemaForm = new CinemaForm();
            cinemaForm.ShowDialog();

        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmeForm filmeForm = new FilmeForm();
            filmeForm.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunconarioForm funconarioForm = new FunconarioForm();
            funconarioForm.ShowDialog();
            UpdateUser();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.ShowDialog();
        }


        private void sesõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessaoForm sessaoForm = new SessaoForm();
            sessaoForm.ShowDialog();
        }

        private void dtpDiadeSessao_ValueChanged(object sender, EventArgs e)
        {
            
            
            var sessoes = appContext.Sessoes.ToList();


            foreach (var sessao in sessoes)
            {
                DateTime dataSelecionada = new DateTime(dtpDiadeSessao.Value.Day, dtpDiadeSessao.Value.Month, dtpDiadeSessao.Value.Day);
                if (sessao.Data == dataSelecionada)
                {
                    lbSessoesMain.Items.Add(sessao);
                }
            }
        }

        private void lbSessoesMain_DoubleClick(object sender, EventArgs e)
        {
            AtendimentoForm atendimentoForm = new AtendimentoForm();

            Sessao sessao = (Sessao)lbSessoesMain.SelectedItem;

            string nome = cbUser.SelectedItem.ToString();

            Funcionario funcionario = appContext.Funcionarios.FirstOrDefault(f => f.Nome == nome);

            Bilhete bilhete = new Bilhete();

            bilhete.IdSessao = sessao.id;
            bilhete.IdFuncionario = funcionario.Id;


            atendimentoForm.MostrarDados(bilhete);

        }

        private void UpdateUser()
        {
            List<Funcionario> funcionarios = appContext.Funcionarios.ToList();
            foreach (Funcionario funcionario in funcionarios)
            {
                    cbUser.Items.Add(funcionario.Nome);
            }
        }
    }

}
