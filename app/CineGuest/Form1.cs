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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbUser.Items.Add("qsabjsjfl");
            cbUser.Items.Add("qsabjsjfl");
            cbUser.Items.Add("qsabjsjfl");
            cbUser.Items.Add("qsabjsjfl");
            cbUser.Items.Add("qsabjsjfl");

        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            /*string user = cbUser.GetItemText(cbUser.SelectedIndex);
            lbltest.Text = user;
            string te1st = cbUser.SelectedItem.ToString();
            lbltest.Text = te1st;*/
            CinemaForm cinemaForm = new CinemaForm();
            cinemaForm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtendimentoForm atendForm = new AtendimentoForm();
            atendForm.ShowDialog();
        }
    }
}
