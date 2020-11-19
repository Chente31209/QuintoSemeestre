using System;
using System.Collections.Generic;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class DistribuciónNormal : IDistribucion
    {
        
        public List<double> GVAleatorias { get ; set ; }
        public void Prosedimeto()
        {
            List<double> SumatoriasDeR = new List<double> { };
            List<double> SumatoriasDeR_6 = new List<double> { };
            List<double> Volumen = new List<double> { };
            Random Rdm = new Random();

            for (var i = 0; i <= 5; i++)
            {
                double R1= Rdm.NextDouble();
                double R2 = Rdm.NextDouble();
                double R3 = Rdm.NextDouble();
                double R4 = Rdm.NextDouble();
                double R5 = Rdm.NextDouble();
                double R6 = Rdm.NextDouble();
                double R7 = Rdm.NextDouble();
                double R8 = Rdm.NextDouble();
                double R9 = Rdm.NextDouble();
                double R10 = Rdm.NextDouble();
                double R11 = Rdm.NextDouble();
                double R12 = Rdm.NextDouble();
                double R13 = Rdm.NextDouble();
                double R14 = Rdm.NextDouble();

                SumatoriasDeR.Add(R1+ R2+ R3+ R4+ R5+ R6+ R7+ R8+ R9 + R11+ R12+ R13);

            }
            foreach (var i in SumatoriasDeR)
            {
                SumatoriasDeR_6.Add(i-6);
            }
            foreach (var i in SumatoriasDeR_6)
            {
                Volumen.Add((0.4*i)+12 );
            }
            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine($"|{SumatoriasDeR[i]}|{SumatoriasDeR_6[i]}|{Volumen[i]}|");
            }

            }
    }
}
