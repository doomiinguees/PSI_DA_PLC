using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineGuest
{
    public partial class AtendimentoForm : Form
    {
        public AtendimentoForm()
        {
            InitializeComponent();
            
        }

        private void AtendimentoForm_Load(object sender, EventArgs e)
        {

            tabSala.SuspendLayout();
            tabSala.Controls.Clear();
            int dez = 14;
            int trinta = 30;
            tabSala.ColumnCount = dez;
            tabSala.RowCount = trinta;
            int coluna = dez;
            int linha = trinta;


            

            for (int i=0; i < linha; i++)
            {
                for (int j=0; j < coluna; j++)
                {
                    Button butao = new Button();
                    butao.Size = new Size(40, 25);
                    butao.Text = (char)(i + 65) + " | " + (j + 1);
                    tabSala.Controls.Add(butao, j, i);

                    butao.Click += Butao_Click;
                }
            }

            tabSala.ResumeLayout();
            tabSala.AutoScroll = true;
        }

        private void Butao_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Red)
            {
                MessageBox.Show("Ligar já ocupado");
            }
            else
            {
                ((Button)sender).BackColor = Color.Red;
                string but = ((Button)sender).Text;

                lbBancos.Items.Add(but);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnFinCompra_Click(object sender, EventArgs e)
        {
            //codigo para adicionar à base de dados os bancos ocupados
        }
    }
}
