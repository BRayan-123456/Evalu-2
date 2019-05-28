using System;

namespace Evaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Billetera billetera = new Billetera();
            Console.WriteLine($"Inserte el valor");
            billetera.valorIngreso = int.Parse(Console.ReadLine());

      
            Console.WriteLine($"Digite el valor que va a descontar");
             var valorgasta=(Convert.ToDouble(Console.ReadLine()));


            Console.WriteLine($"{billetera.Gastar(valorgasta)}");
            Console.ReadLine();

            

           double valortotal = billetera.Gastar(valorgasta);
            billetera.ImprimirDinero(valortotal);
          



        }
}
}
