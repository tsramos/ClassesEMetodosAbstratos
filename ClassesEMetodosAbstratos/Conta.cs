using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEMetodosAbstratos
{
    internal abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public abstract void TaxaDeManutencao();

        public virtual void DetalhesConta()
        {
            Console.WriteLine($"Conta: {Numero}");
        }
    }
}
