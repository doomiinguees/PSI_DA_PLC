using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Pessoa
    {
        public int Id{ get; set; } 
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Localidade { get; set; }
        public string CodPostal { get; set; }

        public Pessoa()
        {
            this.Nome = null;
            this.Rua = null;
        }
    }
}
