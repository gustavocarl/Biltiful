using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrosBasicos.Models
{
    public class Fornecedor
    {
        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }

        public DateTime DataAbertura { get; set; }

        public DateTime UltimaCompra { get; set; }

        public DateTime DataCadastro { get; set; }

        public char Situacao { get; set; }
    }
}