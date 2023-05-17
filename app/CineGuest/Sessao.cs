using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Sessao
    {
        public DateTime DataHora { get; set; }
        public float preco { get; set; }

        public Sessao()
        {
            this.preco = 0;
            this.DataHora = DateTime.Now;
        }
    }
}
