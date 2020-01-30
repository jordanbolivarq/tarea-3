using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.Write("ingrese su salario mensual actual: ");
            double salario = double.Parse(Console.ReadLine());

            double canSmmlv = (salario / 877803);
            //Console.WriteLine("la cantidad de salarios minimos mensuales legales vigentes (SMMLV) es: " + canSmmlv);

            if (canSmmlv < 2)
            {
                Console.WriteLine("aplica a tarifa A");
            }

            else if (2 <= canSmmlv && canSmmlv < 4)
            {
                Console.WriteLine("aplica a tarifa B");
            }

            else
            {
                Console.WriteLine("aplica a tarifa C");
            }
        }
    }
}
