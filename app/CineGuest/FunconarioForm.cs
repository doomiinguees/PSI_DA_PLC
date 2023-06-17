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
    public partial class FunconarioForm : Form
    {
        ApplicationContext appContext = new ApplicationContext();
        public FunconarioForm()
        {
            InitializeComponent();
            UpdateList();
            ClearInputs();
        }

        private void FunconarioForm_Load(object sender, EventArgs e)
        {
            cbFuncao.Items.Add("Administrador");
            cbFuncao.Items.Add("Estagiário");
            cbFuncao.Items.Add("Vendedor");

            string nome = appContext.Cinemas.First().nome;
            this.Text = $"{nome} | Funcionários";
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string funcao = cbFuncao.Text;
            string salariostr = tbSalario.Text;
            string rua = tbMorada.Text;
            string local = tbLocalidade.Text;
            string codPostal = tbCodPostal.Text;

            if (ConfirmaString(nome, "nome") == true || ConfirmaString(funcao, "Função") == true || ConfirmaFloat(salariostr, "Salário") == true ||
                ConfirmaString(rua, "Morada") == true || ConfirmaString(local, "Localidade") == true || ConfirmaString(codPostal, "Código Postal") == true)
            {
                return;
            }
            else
            {
                int select = lbFuncionario.SelectedIndex;

                if (select == -1)
                {
                    Funcionario funcionario = new Funcionario();
                    float salario = float.Parse(salariostr);

                    funcionario.Nome = nome;
                    funcionario.Funcao = funcao;
                    funcionario.Salario = salario;
                    funcionario.Rua = rua;
                    funcionario.Localidade = local;
                    funcionario.CodPostal = codPostal;

                    appContext.Funcionarios.Add(funcionario);
                    appContext.SaveChanges();
                }
                else
                {
                    Funcionario funcionario = lbFuncionario.SelectedItem as Funcionario;
                    float salario = float.Parse(salariostr);

                    funcionario.Nome = nome;
                    funcionario.Funcao = funcao;
                    funcionario.Salario = salario;
                    funcionario.Rua = rua;
                    funcionario.Localidade = local;
                    funcionario.CodPostal = codPostal;

                    appContext.Funcionarios.AddOrUpdate(funcionario);
                    appContext.SaveChanges();
                }
            }
            UpdateList();
            ClearInputs();
        }

        private void lbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lbFuncionario.SelectedIndex;
            if (selected == -1)
            {
                btnAddFuncionario.Text = "Adicionar Funcionário";
                return;
            }
            else
            {
                Funcionario funcionario = lbFuncionario.SelectedItem as Funcionario;

                tbNome.Text = funcionario.Nome;
                cbFuncao.Text = funcionario.Funcao;
                tbSalario.Text = funcionario.Salario.ToString();
                tbMorada.Text = funcionario.Rua;
                tbLocalidade.Text = funcionario.Localidade;
                tbMorada.Text = funcionario.Localidade;
                tbCodPostal.Text = funcionario.CodPostal;

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
            lbFuncionario.DataSource = null;
            lbFuncionario.DataSource = appContext.Funcionarios.ToList();
        }

        public void ClearInputs()
        {
            lbFuncionario.SelectedIndex = -1;
            tbNome.Clear();
            cbFuncao.SelectedIndex = -1;
            tbSalario.Clear();
            tbMorada.Clear();
            tbLocalidade.Clear();
            tbCodPostal.Clear();
        }

        private void btnApagarFuncionario_Click(object sender, EventArgs e)
        {
            int select = lbFuncionario.SelectedIndex;

            if (select == -1)
            {
                return;
            }
            else
            {
                Funcionario funcionario = appContext.Funcionarios.ToList()[select];
                appContext.Funcionarios.Remove(funcionario);
                appContext.SaveChanges();

                UpdateList();
                ClearInputs();
            }
        }
    }
}
