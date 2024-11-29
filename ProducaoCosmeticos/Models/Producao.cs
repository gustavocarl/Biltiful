﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducaoCosmeticos.Models
{
    public class Producao
    {
        public int Id { get; set; }

        public DateTime DataProducao { get; set; }

        public string Produto { get; set; }

        public float Quantidade { get; set; }
    }
}