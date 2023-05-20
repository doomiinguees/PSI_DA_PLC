using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Cinema
    {
        [KEY]
        public int id { set; }
        public string nome { get; set; }
        public string morada { get; set; }
        public string email { get; set; }

        public Cinema()
        {
            this.id = 0;
            this.nome = null;
            this.morada= null;
            this.email = null;
        }

    }
}
