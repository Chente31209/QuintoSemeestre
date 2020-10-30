using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class MGAditivo : IMetodo
    {
        public List<double> X { get; set; }
        public List<double> R { get ; set ; }

        public List<double> Procedimetos(double[] semillas, double M, int numeros)
        {
            X = new List<double> { };
            R = new List<double> { };
            for (int i = 0; i < semillas.Length; i++)
            {
                X.Add(semillas[i]);

            }
            int NumerosEnTotal = numeros + X.Count;
            int semillasOriginales = X.Count;
            for (int i = X.Count; i < NumerosEnTotal; i++)
            {
                var r = X[i - 1];
                var q = X[i - semillasOriginales];
                var c = (r + q) % M;
                X.Add(c);

            }
            for (int i = 0; i < NumerosEnTotal; i++)
            {
                R.Add(X[i] / (M - 1));

            }
            
            return R;

        }

        public void showList()
        {
            foreach (var item in R)
            {
                Console.WriteLine(item);
            }
        }
    }
}
