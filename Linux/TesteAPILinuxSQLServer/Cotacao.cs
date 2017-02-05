using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICotacoes
{
    public class Cotacao
    {
        public string Sigla { get; set; }
        public string NomeMoeda {get;set;}
        public DateTime UltimaCotacao { get; set; }
        public decimal Valor { get; set; }
    }
}