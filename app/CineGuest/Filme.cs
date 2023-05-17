using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Filme
    {
        public string nome { get; set; }
        public float duracao { get; set; }
        public string estado { get; set; }

        public Filme()
        {
            this.nome = null;
            this.duracao = 0;
            this.estado = null;
        }
    }
}
