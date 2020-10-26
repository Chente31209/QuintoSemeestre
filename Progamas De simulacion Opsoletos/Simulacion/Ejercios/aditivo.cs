using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
//practoca 1
namespace Ejercios
{
    public class aditivo 
    {
       /// <summary>
       /// Practia 1
       /// </summary>
       
        public void Procedimetos(double[] semillas, double M, int numeros)
        {
            List<double> Xi=new List<double>{};
            List<double> Ri=new List<double>{};
            for (int i = 0; i < semillas.Length; i++)
            {
                Xi.Add(semillas[i]);
                
            }
            int NumerosEnTotal = numeros+Xi.Count;
            int semillasOriginales = Xi.Count;
            for (int i = Xi.Count; i < NumerosEnTotal ; i++)
            {
                var r=Xi[i-1];
                var q=Xi[i-semillasOriginales];
                var c=(r+q)%M;
                Xi.Add(c);
                
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