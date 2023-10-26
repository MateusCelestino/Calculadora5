using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            decimal idade;
            string sexo;
            decimal altura;
            decimal peso;
            decimal imc;

            Console.WriteLine("nome?");
            Console.Write("seu nome?: ");
            nome = Console.ReadLine();

            Console.WriteLine("idada?");
            Console.Write("seu idade quantos?: ");
            idade = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("sexo homem ou mulher?");
            Console.Write("seu sexo? : ");
            sexo = Console.ReadLine();

            Console.WriteLine("altura?");
            Console.Write("seu altura? : ");
            altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("peso?");
            Console.Write("seu peso? : ");
            peso = Convert.ToDecimal(Console.ReadLine());

            

            imc = peso / (altura * altura);
            Console.WriteLine(
                "seu nome é " + nome + " " + idade + " anos " + sexo + " sexo " 
                + altura + " Altura CM " + peso + " KG " + imc.ToString("F2") + " IMC "
            );




        }
    }
}
