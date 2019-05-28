using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluacion
{
    class Billetera
    {

        public double valorIngreso { get; set; }
        public double valorGastado { get; set; }

        public double valortotal { get; set; }
        public Billetera() { }
        public double Gastar(double gastar) {
            valorGastado = gastar;
            var resultado1 = valorIngreso - gastar;
            return resultado1;
        }

       public void ImprimirDinero(double arriba)
        {
            valortotal = arriba;
            Console.WriteLine($"el valor que hay en la cuenta es: {arriba}");

        }
   
    }

    
}
