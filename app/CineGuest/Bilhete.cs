using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Bilhete
    {
        public string lugar { get; set; }
        public string estado { get; set; }

        public Bilhete()
        {
            this.lugar = null;
            this.estado = null;
        }
    }
}
