using System;
using ITSZO.Simulacion.Library;

namespace ITSZO.Simulcion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] semillas = new double[9] { 65, 89, 98, 8, 6, 4, 89, 54, 56 };
            MGAditivo mGAditivo = new MGAditivo();
            mGAditivo.Procedimetos(semillas, 100, 7);
            mGAditivo.showList();
        }
    }
}
