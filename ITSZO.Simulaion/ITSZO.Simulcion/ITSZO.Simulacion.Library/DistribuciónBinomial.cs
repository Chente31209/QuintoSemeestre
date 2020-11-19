using System;
using System.Collections.Generic;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class DistribuciónBinomial : IDistribucion
    {
        public List<double> GVAleatorias { get; set; }
        
        public void Prosedimeto()
        {
            Random Rdm = new Random();
            List<double> PiesasDeLoto = new List<double> { 0, 0, 0, 0, 0 };
            for (int i=0;i<=4;i++)
            {
                for (int j = 0; i <= 4; i++)
                {
                    double R= Rdm.NextDouble();
                    if (R > 0.9)
                        PiesasDeLoto[i] = PiesasDeLoto[i] + 0;
                    else
                        PiesasDeLoto[i] = PiesasDeLoto[i] + 1;

                }
           
            }
            int ind = 1;
        foreach (var i in PiesasDeLoto)
            {
                Console.WriteLine($"{ind++}|{i}");
            }
        }

    }
}
