using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEMetodosAbstratos
{
    internal class ContaPoupanca : Conta
    {
        public string Titular { get; set; }

        public override void TaxaDeManutencao()
        {            
            Saldo += 10;
        }
    }
}
