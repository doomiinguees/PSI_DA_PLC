using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Cinema
    {
        public string nome { get; set; }
        public string morada { get; set; }
        public string email { get; set; }

        public Cinema()
        {
            this.nome = null;
            this.morada= null;
            this.email = null;
        }

    }
}
