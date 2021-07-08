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
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // o int é um tipo de variavel de 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            Console.WriteLine("Execusão finalizada. Tecle entre para sair...");

            // O long é uma variavel de 64 bits 
            long idade = 130000000000000;

            //O short é uma variavel de 16 bits
            short qtdProdutos = 16000;

            float altura = 1.80f;

            Console.WriteLine(idade);
            Console.WriteLine(qtdProdutos);
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
