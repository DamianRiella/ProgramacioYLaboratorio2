using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, vali, flag=0;

            do {
                Console.WriteLine("Ingrese un numero");
                num = Console.ReadLine();

                if (num > 0)
                {
                    int.TryParse(num, out vali);
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("Error.¡Reingresar numero!");
                }
            } while (flag != 1);
        }
    }
}
