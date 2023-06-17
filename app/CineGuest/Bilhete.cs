﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    public class Bilhete
    {
        [Key]
        public int id {  get; set; }
        public string lugar { get; set; }
        public string estado { get; set; }
        public int IdSessao { get; set; }
        public int IdFuncionario { get; set; } 
        public int IdCliente { get; set; }

        public Bilhete()
        {
            this.lugar = null;
            this.estado = null;
        }
    }
}
