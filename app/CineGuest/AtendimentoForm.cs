﻿using System;
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
    public partial class AtendimentoForm : Form
    {
        public AtendimentoForm()
        {
            InitializeComponent();
            tabSala.ColumnCount = 18;
            tabSala.RowCount = 30;
            int[,] data = new int[10,30];


        }

        private void AtendimentoForm_Load(object sender, EventArgs e)
        {
            

            
        }
    }
}
