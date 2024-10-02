using System;

namespace ClassesEMetodosAbstratos
{
    internal abstract class ImovelBase
    {      

        public abstract string Fundacao { get; set; }
        public int Sapatas { get; set; }
        public double TamanhoTerreno { get; set; }

        public abstract void GeraEscrituraTerreno(string proprietario);

        public virtual void ImprimeInformacoes()
        {
            Console.Write($"Imovel com {Sapatas} satatas feitas de {Fundacao}, em um terreno de {TamanhoTerreno}.");
        }
    }
}
