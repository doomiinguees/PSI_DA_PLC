﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Sala
    {
        public string nome { get; set; }
        public int colunas { get; set; }
        public int linhas { get; set; }

        public Sala()
        {
            this.nome = string.Empty;
            this.colunas = 0;
            this.linhas = 0;
        }
    }
}
