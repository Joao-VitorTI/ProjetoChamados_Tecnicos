﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Chamados
    {
        public int CodigoChamado { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Ocorrencia { get; set; }
        public string Problema { get; set; }
        public bool Concluido { get; set; }
        public int fk_Clientes_CodigoCliente { get; set; }
        public int fk_Tecnicos_CodigoTecnico { get; set; }
    }
}
