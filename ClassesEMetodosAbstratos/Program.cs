using System;
using System.Collections.Generic;

namespace ClassesEMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Casa casa = new Casa();            
            List<ImovelBase> imoveis = new List<ImovelBase>()
            {               
                new Casa()
                {
                    Fundacao = "Concreto",
                    Sapatas = 1,
                    Comodos = 4,
                    MetrosQuadrados = 55,
                    NumeroQuartos = 1
                }, 
                new Sobrado()
                {
                    Sapatas = 6,
                    Andares = 4,
                    Fundacao = "Concreto Usinado",
                    NumeroQuartos = 6,
                    TamanhoTerreno = 900,
                    TemElevador = true,
                }
            };
        }
    }
}
