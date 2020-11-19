using System;
using System.Collections.Generic;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class DitribuciónBenuli : IDistribucion
    {
        public List<double> GVAleatorias { get ; set; }
        MGCuadratico gCuadratico = new MGCuadratico();
        public List<double> Prosedimeto()
        {
            GVAleatorias = new List<double> { };
            foreach (var i in gCuadratico.Procedimeto())
            {
                if (i <= 0.8)
                    GVAleatorias.Add(0);
                if (i > 0.8)
                    GVAleatorias.Add(1);
            }
            
            return GVAleatorias;
        }
        public void show()
        {
            int inde=0;

            foreach(var i in Prosedimeto())
            {
                if (i == 0)
                    Console.WriteLine($"Dia{inde+1} | R { gCuadratico.Procedimeto()[inde]}| X {i}| no Falla");
                if (i == 1)
                    Console.WriteLine($"Dia{inde + 1} | R { gCuadratico.Procedimeto()[inde]}| X {i}|  Falla");
                inde++;
            }
        }
    }
}
