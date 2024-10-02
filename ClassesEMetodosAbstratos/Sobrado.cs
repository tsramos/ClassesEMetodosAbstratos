namespace ClassesEMetodosAbstratos
{
    internal class Sobrado : ImovelBase
    {
        public override int  Sapatas { get; set; }
        public override string Fundacao { get; set; }

        public int NumeroQuartos { get; set; }
        public int Andares { get; set; }
        public bool TemElevador { get; set; }

        public override void GeraEscrituraTerreno(string proprietario)
        {
            base.GeraEscrituraTerreno(proprietario);   
        }

        public override void ImprimeInformaoes()
        {
            base.ImprimeInformacoes();
        }
    }
}
