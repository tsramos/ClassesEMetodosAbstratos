using System;

namespace ClassesEMetodosAbstratos
{
    internal class Casa : ImovelBase
    {
        public override string Fundacao { get; set; }
        public override int Sapatas { get; set; }
        public int Comodos { get; set; }
        public double MetrosQuadrados { get; set; }
        public int NumeroQuartos { get; set; }

        public override void GeraEscrituraTerreno(string proprietario)
        {
            Console.WriteLine("Escritura de residencia ...");
        }
    }
}
