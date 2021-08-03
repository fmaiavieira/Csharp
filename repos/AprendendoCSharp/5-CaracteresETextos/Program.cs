using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e texto");

            //character(usar aspas simples)
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //numero 65 é referente a tabela ASCII table 65=A
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2020;
            string cursosprogamacao = @"
                 - .NET
                 - Java 
                 - JavaScript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosprogamacao);


            Console.ReadLine();
        }
    }
}
