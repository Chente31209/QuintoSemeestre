using System;
using System.Collections.Generic;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class DistribuciónExponencial : IDistribucion
    {
        public List<double> GVAleatorias { get ; set ; }
        MGCuadratico gCuadratico = new MGCuadratico();

        public List<double> Prosedimeto()
        {

            GVAleatorias = new List<double> { };
            for (var i = 0; i <= 5; i++)
            {
                // —3ln(1 - r)
                GVAleatorias.Add(-3*(Math.Log(1-gCuadratico.Procedimeto()[i])));
            }
            return GVAleatorias;
        }
        public void Show()
        {
            int index = 0;
            foreach (var item in Prosedimeto())
            {
                Console.WriteLine($"Iteracion {index + 1} | R{ gCuadratico.Procedimeto()[index]} | X {item}  ");
                index++;
            }
        }
    }
}
