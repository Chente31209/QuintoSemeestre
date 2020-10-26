using System;
using System.Collections.Generic;

namespace Libreia
{
    public class MetodoAditibo
    {
        public List<NumeroPseudoalatorios> Proseditos(double[] semillas, double M, int numeros)
        {
            List<NumeroPseudoalatorios> Numeros =new List<NumeroPseudoalatorios>{};
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
            Numeros.Add(new NumeroPseudoalatorios(){xi=Xi,ri=Ri});
            return Numeros;
        }
    }
}
