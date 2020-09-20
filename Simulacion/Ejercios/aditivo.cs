using System;
using static System.Console;
using System.Collections.Generic;

namespace Ejercios
{
    public class aditivo 
    {
        public aditivo()
        {
            
        }
        public void Procedimetos(double[] semillas, double M, int numeros)
        {
            List<double> Xi=new List<double>{};
            List<double> Ri=new List<double>{};
            for (int i = 0; i < semillas.Length; i++)
            {
                Xi.Add(semillas[i]);
                
            }
            int NumerosEnTotal = numeros+Xi.Count;
            for (int i = Xi.Count; i < NumerosEnTotal ; i++)
            {
                Xi.Add((Xi[i-1]+Xi[i-Xi.Count])%M);
                
            }
            for (int i = 0; i < NumerosEnTotal; i++)
            {
                Ri.Add(Xi[i]/(M-1));
                
            }
            int index=0;
            foreach (var item in Xi)
            {
                WriteLine($"{index} Numero ->{item} Pseudo Numerp ->{Ri[index]}");
                index++;
            }

            
        }
    }
}