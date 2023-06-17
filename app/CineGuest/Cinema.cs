using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    public class Cinema
    {
        [Key]
        public int id { get;  set; }
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
