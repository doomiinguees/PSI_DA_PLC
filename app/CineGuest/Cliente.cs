using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Cliente : Pessoa
    {
        public int NIF { get; set; }

        public Cliente()
        {
            this.NIF = 0;
        }


        public override string ToString()
        {
            
            return $"{nome} - {NIF}";
        }
    }
}
