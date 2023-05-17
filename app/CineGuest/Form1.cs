using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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

            /*
             * busca dados das sessoes e preenche a main

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Button butao = new Button();
                    butao.Size = new Size(40, 25);
                    butao.Text = (char)(i + 65) + " | " + (j + 1);
                    tabSala.Controls.Add(butao, j, i);

                    butao.Click += Butao_Click;
                }
            }
            */
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
            
        }
    }
}
