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
    public partial class ClienteForm : Form
    {
        ApplicationContext appContext = new ApplicationContext();
        public ClienteForm()
        {
            InitializeComponent();
            lbCliente.SelectedIndex = -1;
            UpdateList();
            ClearInputs();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            lbCliente.SelectedIndex = -1;
            UpdateList();
            ClearInputs();
            string nome = appContext.Cinemas.First().nome;
            this.Text = $"{nome} | Clientes";
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string nifstr = tbNIF.Text;
            string rua = tbMorada.Text;
            string local = tbLocalidade.Text;
            string codPostal = tbCodPostal.Text;

            if (ConfirmaString(nome, "nome") == true || ConfirmaInt(nifstr, "Número de Indentificação Fiscalq") == true || ConfirmaString(rua, "Morada") == true ||
                ConfirmaString(local, "Localidade") == true || ConfirmaString(codPostal, "Código Postal") == true)
            {
                return;
            }
            else
            {
                int select = lbCliente.SelectedIndex;
                if (select == -1)
                {
                    int nif = int.Parse(nifstr);

                    Cliente cliente = new Cliente();
                    cliente.Nome = nome;
                    cliente.NIF = nif;
                    cliente.Rua = rua;
                    cliente.Localidade = local;
                    cliente.CodPostal = codPostal;

                    appContext.Clientes.Add(cliente);
                    appContext.SaveChanges();
                }
                else
                {
                    int nif = int.Parse(nifstr);

                    Cliente cliente = lbCliente.SelectedItem as Cliente;
                    cliente.Nome = nome;
                    cliente.NIF = nif;
                    cliente.Rua = rua;
                    cliente.Localidade = local;
                    cliente.CodPostal = codPostal;

                    appContext.Clientes.AddOrUpdate(cliente);
                    appContext.SaveChanges();
                }
            }
            UpdateList();
            ClearInputs();
        }

        private void lbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = lbCliente.SelectedIndex;
            if (select == -1)
            {
                btnAddCliente.Text = "Adicionar Cliente";
                ClearInputs();
                return;
            }
            else
            {
                Cliente cliente = lbCliente.SelectedItem as Cliente;

                tbNome.Text = cliente.Nome;
                tbNIF.Text = cliente.NIF.ToString();
                tbMorada.Text = cliente.Rua;
                tbLocalidade.Text = cliente.Localidade;
                tbCodPostal.Text = cliente.CodPostal;

                btnAddCliente.Text = "Atualizar Cliente";

                int nbilhetes = 0;

                foreach (var item in appContext.Bilhetes)
                {
                    if (item.IdCliente == cliente.Id)
                    {
                        nbilhetes++;
                    }
                }

                lblnBilhetes.Text = nbilhetes.ToString();

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

        public bool ConfirmaInt(string verificar, string dado)
        {
            int data;

            if (!int.TryParse(verificar, out data) || data < 0 || verificar.Length != 9)
            {
                MessageBox.Show($"{dado} inválid@");
                return true;
            }
            else
            {
                List<Cliente> clientes = appContext.Clientes.ToList();
                foreach (var item in clientes)
                {
                    if (item.NIF == int.Parse(verificar))
                    {
                        MessageBox.Show($"{dado} inválid@");
                        return true;
                    }
                }
                return false;
            }
        }

        public void UpdateList()
        {
            lbCliente.DataSource = null;
            lbCliente.DataSource = appContext.Clientes.ToList();
        }

        public void ClearInputs()
        {
            lbCliente.SelectedIndex = -1;
            tbNome.Clear();
            tbNIF.Clear();
            tbMorada.Clear();
            tbLocalidade.Clear();
            tbCodPostal.Clear();
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            int select = lbCliente.SelectedIndex;

            if (select == -1)
            {
                return;
            }
            else
            {
                Cliente cliente = appContext.Clientes.ToList()[select];
                appContext.Clientes.Remove(cliente);
                appContext.SaveChanges();

                UpdateList();
                ClearInputs();
            }
        }
    }
}
