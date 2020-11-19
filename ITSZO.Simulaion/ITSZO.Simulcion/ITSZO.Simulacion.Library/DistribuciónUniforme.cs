using System;
using System.Collections.Generic;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class DistribuciónUniforme: IDistribucion
    {
        public List<double> GVAleatorias { get; set; }
        MGCuadratico gCuadratico = new MGCuadratico();

        public List<double> Prosedimeto()
        {
           
            GVAleatorias = new List<double> { };
            for (var i=0; i <= 5; i++)
            {
                GVAleatorias.Add((650 + (5 * gCuadratico.Procedimeto()[i])));
            }
            return GVAleatorias;
        }
        public void Show()
        {
            int index = 0;
            foreach(var item in Prosedimeto())
            {
                Console.WriteLine($"Iteracion {index+1} | R{ gCuadratico.Procedimeto()[index]} | X {item}  ");
                index++;
            }
        }
    }
}
