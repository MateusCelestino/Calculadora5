using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal prova_1;
            decimal prova_2;
            decimal prova_3;
            decimal prova_4;
            decimal resultado_media;
            decimal resultado_nota;

            Console.WriteLine("Prova 01");

            Console.Write("Prova o 01 numero nota: ");
            prova_1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Prova 02");

            Console.Write("Prova o 02 numero nota: ");
            prova_2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Prova 03");
            Console.Write("Prova o 03 numero nota: ");
            prova_3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Prova 04");
            Console.Write("Prova o 03 numero nota: ");
            prova_4 = Convert.ToDecimal(Console.ReadLine());

            // resultado_media = (prova_1 + prova_2 + prova_3 + prova_4) / 4;

            decimal[] numero = {prova_1, prova_2, prova_3, prova_4};
            resultado_media = numero.Average();

            Console.WriteLine(
             "A média do numero " + prova_1 + " e " + prova_2 + " e " + prova_3 + " e "
             + prova_4 + " é: " + resultado_media
            );





        }
    }
}
