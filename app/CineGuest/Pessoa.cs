using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public string morada { get; set; }

        public Pessoa()
        {
            this.nome = null;
            this.morada = null;
        }
    }
}
