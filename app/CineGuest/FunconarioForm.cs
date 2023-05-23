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
    public partial class FunconarioForm : Form
    {
        public FunconarioForm()
        {
            InitializeComponent();
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string funcao = cbFuncao.Text;
            string rua = tbMorada.Text;
            string local = tbLocalidade.Text;
            string codPostal = tbCodPostal.Text;
            
        }
    }
}
