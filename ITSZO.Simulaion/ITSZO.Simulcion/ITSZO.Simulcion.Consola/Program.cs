using System;
using System.Xml.Serialization;
using ITSZO.Simulacion.Library;

namespace ITSZO.Simulcion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DistribuciónPoison poison = new DistribuciónPoison();
            poison.Procedimeto();
            
           DistribuciónNormal normal = new DistribuciónNormal();
           normal.Prosedimeto();

           DistribuciónBinomial binomial = new DistribuciónBinomial();
           binomial.Prosedimeto();
           
        }
    }
}
