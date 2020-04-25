using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfiVersaoUm
{
    class RelatorioVendas
    {
        public double Valor { get; private set; }
        public DateTime Data { get; set; }

        public RelatorioVendas(double valor, DateTime data)
        {
            Valor = valor;
            Data = data;
        }
    }
}
