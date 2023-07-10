using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GnassoPOO.Entidades;

namespace GnassoPOO.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Ingresar el radio del cono:");
                var radio = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar su altura:");
                var altura = double.Parse(Console.ReadLine());

                var cono = new Cono(altura, radio);

                Console.WriteLine($"El volumen del cono es: {cono.GetVolumen(altura, radio)}");
                Console.WriteLine($"El area es: {cono.GetArea(radio, altura)}");
                Console.WriteLine( cono.ToString());
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
