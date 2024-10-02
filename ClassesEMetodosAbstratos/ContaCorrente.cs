using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEMetodosAbstratos
{
    internal class ContaCorrente : Conta
    {

        public override void TaxaDeManutencao()
        {
            Saldo -= 15.00;
        }

        public override void DetalhesConta()
        {
            base.DetalhesConta();
            Console.WriteLine("Conta Corrente");
        }
    }
}
