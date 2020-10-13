using System;

namespace Ejercios
{
    class Program
    {
        /// <summary>
        /// @Autor Vicente Eduardo 
        /// </summary>
        /// <param name="args"></param>
       
        static void Main(string[] args)
        {
            
            double[] semillas = new double[5]{65 ,89 , 98 ,3 ,69 };
            aditivo aditivo1= new aditivo();
            aditivo1.Procedimetos(semillas,100,7);
            Console.WriteLine("Cuadratico");
            Cuadratico cuadratico=new Cuadratico();
            cuadratico.procedimeto(13,8,26,27,27);
            Console.WriteLine("Blim Blim");
            BlimBlim blim=new BlimBlim();
            blim.procedimeto(12.0,100,10);
            
        }

        
    }
}
