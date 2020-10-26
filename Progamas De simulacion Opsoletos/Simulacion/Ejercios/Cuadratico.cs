using System;
using System.Collections.Generic;
namespace  Ejercios

{
    public class Cuadratico
    {
        //pratica
        public void procedimeto(double X0,double m,double a, double b, double c)
        {
            List<double> Xi=new List<double>{};
            Xi.Add(X0);
            for(var i=0;i<=10;i++)
            {
                // (aX¡2 + bX¡ + c ) mod (m) 
                
                //double x=((a*Math.Pow(Xi[i], 2))+((b*Xi[i])+c))%m;
                Xi.Add(((a*Math.Pow(Xi[i], 2))+((b*Xi[i])+c))%m);
            }
            foreach (var item in Xi)
            {
              Console.WriteLine($"{item}"); 
            }

        }
    }
}