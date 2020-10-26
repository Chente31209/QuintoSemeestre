using System;
using System.Collections.Generic;
namespace Ejercios
{
    public class BlimBlim
    {
        public void procedimeto(double X0, double m, int numeros)
        {
            List<double> Xi = new List<double>{};
            Xi.Add(X0);
            for(var i=0; i<=numeros;i++)
            {
                var XCuadrdo=Math.Pow(Xi[i],2);
                var Numero=XCuadrdo%m;
                Xi.Add(Numero);

            }
            foreach (var item in Xi)
            {
                Console.WriteLine(item);
            }
        }
    }
}