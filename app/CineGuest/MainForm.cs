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

            string data = DateTime.Now.ToString("dd/MM/yyyy");

            List<Sessao> sessoes = appContext.Sessoes.Where(s => s.Data == data).ToList();

            lbSessoesMain.Items.Clear();

            foreach (Sessao sessao in sessoes)
            {
                lbSessoesMain.Items.Add(sessao);
            }
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
                if (sessao.Data == dtpDiadeSessao.Value.ToString("dd/MM/yyyy"))
                {
                    lbSessoesMain.Items.Add(sessao);
                }
            }
        }

        private void lbSessoesMain_DoubleClick(object sender, EventArgs e)
        {
            AtendimentoForm atendimentoForm = new AtendimentoForm();

            Sessao sessao = (Sessao)lbSessoesMain.SelectedItem;

            Funcionario funcionario = (Funcionario)cbUser.SelectedItem;

            Bilhete bilhete = new Bilhete();
            /*
            bilhete.IdSessao = sessao.id;
            bilhete.IdFuncionario = funcionario.Id;

            atendimentoForm.Bilhete =bilhete;
            atendimentoForm.ShowDialog();
            */
        }
    }

}
