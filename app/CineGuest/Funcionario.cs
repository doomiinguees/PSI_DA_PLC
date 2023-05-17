using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    internal class Funcionario : Pessoa
    {
        public float salario { get; set; }
        public string funcao { get; set; }

        public Funcionario()
        {
            this.funcao = null;
            this.salario = 0;
        }
    }
}
