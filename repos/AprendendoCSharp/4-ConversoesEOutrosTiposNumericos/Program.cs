using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario = 1200.50;

            // int é um tipo de variável que suporta valores de até 32 bits (até 2 milhões)
            int salarioEmInteiro;
            
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // o Long é um tipo de variável de até 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variável de até 16 bits(16 mil)
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
