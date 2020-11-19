using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class MGCuadratico : IMetodo
    {
        double x, g, k, paz;
        public MGCuadratico(double X=17.0, double G =6, double K =2, double Paz=8)
        {
            this.x = X;
            this.g = G;
            this.k = K;
            this.paz = Paz;
        }

        public List<double> X { get; set; }
        public List<double> R { get; set; }

        public List<double> Procedimeto()
        {
            X = new List<double> { };
            R = new List<double> { };

            double m = Math.Pow(2, g);
            double a = 3 + (8 * k);
            double N = Math.Pow(2, g - 2);
            int pv = int.Parse($"{N}");
            X.Add(x);

            for (var i = 0; i <= pv; i++)
            {
                X.Add((a * X[i]) % m);
            }
            for (var i = 1; i <= pv + 1; i++)
            {
                var operacion = X[i] / (m - 1);
                R.Add(operacion);
            }

            return R;
        }
        public void showList()
        {
            var r = Procedimeto();
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
