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
            /*          Label label = new Label();
                      label.Text = "Hello, world!"; Label label1 = new Label();
                      label1.Text = "Hello, world!";



                      tabSala.Controls.Add(label1, 0, 0);
            */

            tabSala.SuspendLayout();
            tabSala.Controls.Clear();
            int dez = 10;
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
                    butao.Text = (char)(i + 65) + "|" + (j + 1);
                    tabSala.Controls.Add(butao, j, i);
                }
            }

            tabSala.ResumeLayout();
        }
        
        private void butao_Click()
        {
            BackColor = Color.Red;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
