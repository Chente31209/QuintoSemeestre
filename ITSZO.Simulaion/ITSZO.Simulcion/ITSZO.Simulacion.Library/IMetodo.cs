using System;
using System.Collections.Generic;
using System.Text;

namespace ITSZO.Simulacion.Library
{
    public interface IMetodo
    {
         List<double> X { get; set; }
         List<double> R { get; set; }
        void showList();
    }
}
