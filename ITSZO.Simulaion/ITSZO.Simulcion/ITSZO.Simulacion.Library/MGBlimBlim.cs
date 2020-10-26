using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public class MGBlimBlim : IMetodo
    {
        private double X0;
        private double m;
        private int numeros;
        public MGBlimBlim(double x0=15, double M=100, int Numerosdesiados=10)
        {
            this.m = M;
            this.numeros = Numerosdesiados;
            this.X0 = x0;
        }


        public List<double> X { get ; set; }
        public List<double> R { get ; set ; }

        public List<double> GetListPseudoAlatorio()
        {
            X = new List<double> { };
            R = new List<double> { };
            X.Add(X0);
            for (var i = 0; i <= numeros; i++)
            {
                var XCuadrdo = Math.Pow(X[i], 2);
                var Numero = XCuadrdo % m;
                X.Add(Numero);
                
            }
            foreach(var item in X)
            {
                R.Add(item / (m - 1));
            }

            return R;
        }

        public void showList()
        {
          
           foreach (var item in GetListPseudoAlatorio().GroupBy(x=>x.ToString()).Select(x => x.FirstOrDefault()))
            {
                Console.WriteLine($"{item}");
            }
        }

    }
}
