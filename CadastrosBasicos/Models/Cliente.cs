using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrosBasicos.Models
{
    public class Cliente
    {
        public string CPF { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public char Sexo { get; set; }

        public DateTime UltimaCompra { get; set; }

        public DateTime DataCadastro { get; set; }

        public char Situacao { get; set; }
    }
}
