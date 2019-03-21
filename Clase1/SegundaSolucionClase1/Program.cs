using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaSolucionClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0, e=0;
            int i, validacion;
            char opcion;

            Console.WriteLine("Se pedira que ingrese 5 numeros en 5 difernentes casilleros que van del 1 al 5.");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("señalise casillero(1-5):");
                opcion= Console.ReadLine();
                int.TryParse(opcion, out validacion);
               
                if (validacion == 1)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("ingrese un numero:");
                            a =Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("ingrese un numero:");
                            b = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("ingrese un numero:");
                            c = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("ingrese un numero:");
                            d = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("ingrese un numero:");
                            e = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Error. Elnumero ingresado no es correcto.");
                            break;
                    }
                }
                else
                {
                    Console.ReadLine("Error. No se pudo parsear el numero.");
                }
               
            }

            Console.ReadKey();


        }
    }
}
