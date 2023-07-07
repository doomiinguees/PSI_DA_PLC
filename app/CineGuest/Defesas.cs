using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGuest
{
    public class Defesas
    {
        [Key]
        public int Id { get; set; }
        public string NomeAluno { get; set; }
        public int Numero { get; set; }
        public double Contribuicao { get; set; }
        public TimeSpan Hora { get; set; }

        public Defesas(int id, string nomeAluno, int numero, double contribuicao, TimeSpan hora)
        {
            Id = id;
            NomeAluno = nomeAluno;
            Numero = numero;
            Contribuicao = contribuicao;
            Hora = hora;

        }

        public Defesas()
        {
        }

        public override string ToString()
        {
            return $"{NomeAluno} ({Numero}): {Contribuicao}%: {Hora}";
        }
    }
}
