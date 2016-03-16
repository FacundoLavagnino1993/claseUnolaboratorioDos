using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsoDeTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uso de try parse";
            string dato;
            Console.WriteLine("Ingrese su edad: ");
            dato = Console.ReadLine();
            int numero;
            //numero = int.Parse(dato);
            while (int.TryParse(dato, out numero) == false)
            {
                Console.WriteLine("Error intente reingresando un numero");
                dato = Console.ReadLine();
            }
        }
    }
}
