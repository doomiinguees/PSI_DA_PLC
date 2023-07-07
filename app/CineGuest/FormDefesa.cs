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
    public partial class FormDefesa : Form
    {
        ApplicationContext appContext = new ApplicationContext();
        public FormDefesa()
        {
            InitializeComponent();
            lbDefesas.DataSource = null;
            lbDefesas.DataSource = appContext.Defesa.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string numero = txtNumero.Text;
            string contribuicao = txtContribuicao.Text;
            DateTime time = DateTime.Now;
            int horas = time.Hour;
            int minutos = time.Minute;
            int segundos = 0;

            TimeSpan hora = new TimeSpan(horas, minutos, segundos);

            if (VerificaCont(contribuicao) == false ) {
                return;
            }
            else
            {
                int num = int.Parse(numero);
                int cont = int.Parse(contribuicao);

                Defesas defesa = new Defesas();

                defesa.NomeAluno = nome;
                defesa.Numero = num;
                defesa.Contribuicao = cont;
                defesa.Hora = hora;

                appContext.Defesa.Add(defesa);
                appContext.SaveChanges();

                lbDefesas.DataSource = null;
                lbDefesas.DataSource = appContext.Defesa.ToList();

                txtNome.Clear();
                txtContribuicao.Clear();
                txtNumero.Clear();
            }


        }

        public bool VerificaCont(string verificar)
        {
            int data;

            if (!int.TryParse(verificar, out data) || data < 0 || verificar.Length > 100)
            {
                MessageBox.Show($"Contribuição inválid@");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
