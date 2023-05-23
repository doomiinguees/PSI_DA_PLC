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
        public SessaoForm()
        {
            InitializeComponent();

        }

        private void btnAddSessao_Click(object sender, EventArgs e)
        {
            string sala = cbSala.Text.ToString();
            string filme = cbFilme.Text.ToString();
            
        }
    }
}
