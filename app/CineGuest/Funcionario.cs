using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    public class Funcionario : Pessoa
    {
        public float Salario { get; set; }
        public string Funcao { get; set; }

        public Funcionario()
        {
            this.Funcao = null;
            this.Salario = 0;
        }

        public override string ToString()
        {
            return $"{Nome} | {Funcao} | {Salario}€ | {Rua} - {Localidade} - {CodPostal}";
        }
    }
}
