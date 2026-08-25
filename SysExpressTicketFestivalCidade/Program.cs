using System;
using System.Globalization;

namespace FestivalCidade
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("===Sistema de Ingresso Express Festival Cidade===");

            Console.Write("Nome do Fã: ");
            string name = Console.ReadLine();

            Console.Write("Quantidade de Dias de Show: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Cupom: ");
            string cupom = Console.ReadLine();

            Console.Write("Pontuação Fidelidade: ");
            int pontos = int.Parse(Console.ReadLine());

            double taxaservico = 15.0;
            double precoIngresso = 120.0;

            
        }
    }
}