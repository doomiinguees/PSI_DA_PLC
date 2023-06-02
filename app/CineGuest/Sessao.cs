using System;
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
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public float Preco { get; set; }

        public Sessao()
        {
            this.id = this.id + 1;
            this.Preco = 0;
            this.Data = DateTime.Now;
            this.Hora = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Filmes} | {Salas} | {Data.ToString("dd/MM/yyyy")} {Hora.ToString("hh:mm")} | {Preco}";
        }
    }
}
