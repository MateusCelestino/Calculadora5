using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Mateus ";
            string sobrenome = "Celestino";            
            //string nomeCompleto = nome + " " + sobrenome;
            string nomeCompleto = nome +  sobrenome;
            decimal altura = 1.83m;
            float peso = 113f;
            double tamanho_pe = 43;
            char sexo = 'M';
            bool empregado = true;
            int idade = 30;

            Console.WriteLine(nomeCompleto);            
            Console.WriteLine(altura);
            Console.WriteLine(peso);
            Console.WriteLine(tamanho_pe);
            Console.WriteLine(sexo);
            Console.WriteLine(empregado);
            Console.WriteLine(idade);
        }
    }
}
