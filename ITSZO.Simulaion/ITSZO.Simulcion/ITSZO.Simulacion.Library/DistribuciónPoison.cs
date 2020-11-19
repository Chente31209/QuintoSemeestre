using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class DistribuciónPoison : IDistribucion
    {
        public List<double> GVAleatorias { get; set; }

        public void Procedimeto(int Numeros = 10)
        {
            List<int> X = new List<int> { };
            List<double> Px = new List<double> { };
            List<double> PxA = new List<double> { };
            var lista = PseudoAlatorio.alatero(5);
            int PiesasPorDia = 0;
            for (int i = 0; i <= Numeros; i++)
            {
                X.Add(i);
            }

            foreach (int i in X)
            {
                Px.Add((Math.Pow(2, i) * Math.Pow(Math.E, -2)) / fac(i));
            }
            double pa = 0.0;
            foreach (var i in X)
            {
                
                pa = pa + Px[i];
                PxA.Add(pa);
            }
            for (int i = 0; i <= 5; i++)
            {
                foreach (var j in lista)
                {
                    foreach (var k in X)
                    {
                        if (k == 0)
                        {
                            if (j > 0 && j < PxA[0])
                                PiesasPorDia = PiesasPorDia + 0;
                        }
                        else
                        {
                            if (j > PxA[k - 1] && j < PxA[k])
                                PiesasPorDia = PiesasPorDia + k;
                        }

                        
                    }
                    Console.WriteLine(PiesasPorDia);
                }
            }
        }

        static int fac(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static List<double> alatero(int Numeros)
        {
            Random random = new Random();
            List<double>  R = new List<double> { };
            for (int i = 0; i == Numeros; i++)
            {
                R.Add(random.NextDouble());
            }
            return R;
        }
    }
}
