using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    public class Cliente : Pessoa
    {
        public int NIF { get; set; }

        public Cliente()
        {
            this.NIF = 0;
        }


        public override string ToString()
        {
            
            return $"{Nome} | {NIF} |  {Rua} - {Localidade} - {CodPostal}";
        }
    }
}
