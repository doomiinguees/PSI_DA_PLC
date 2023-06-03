﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Sessao
    {
        [Key]
        public int id { get; set; }
        public string Salas { get; set; }
        public string Filmes { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public float Preco { get; set; }

        public Sessao() { }

        public Sessao(int id, string salas, string filmes, string data, string hora, float preco)
        {
            this.id = this.id + 1;
            this.Preco = 0;
            this.Data = Data;
            this.Hora = Hora;
            this.Preco = Preco;
        }

        public override string ToString()
        {
            return $"{Filmes} | {Salas} | {Data} {Hora} | {Preco}€";
        }
    }
}
