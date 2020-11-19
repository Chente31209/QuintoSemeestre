using System;
using System.Collections.Generic;
using System.Text;


namespace ITSZO.Simulacion.Library
{
    public static class PseudoAlatorio
    {
        public static List<double> R { get; set; } 

        public static List<double> alatero(int Numeros)
        {
            
            Random random = new Random();
            R = new List<double> { };
            for (int i=0; i<= Numeros; i++)
            {
                R.Add(random.NextDouble());
            }
            return R ;
        }
    }
}
