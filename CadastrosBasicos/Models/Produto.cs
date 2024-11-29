using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrosBasicos.Models
{
    public class Produto
    {
        public string CodigoBarras { get; set; }

        public string Nome { get; set; }

        public float ValorVenda { get; set; }

        public float UltimaVenda { get; set; }

        public char Situacao { get; set; }
    }
}
