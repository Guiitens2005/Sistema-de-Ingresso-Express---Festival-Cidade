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

            double custoBruto = taxaservico + (precoIngresso * quantidade);

            double desconto = 0.0;
            if (cupom.ToUpper() = "ROCK10")
            {
                desconto = custoBruto * 0.10;
            }

            double valorFinal = custoBruto - desconto;

            bool elegivelVIP = (quantidade > 1) && (pontos >= 500);

            Console.WriteLine("\n--- Resumo do Pedido ---");
            Console.WriteLine($"Fã: {name.ToUpper()}");
            Console.WriteLine($"Valor Bruto: {custoBruto.ToString("C")}");
            Console.WriteLine($"Desconto: {desconto.ToString("C")}");
            Console.WriteLine($"Valor Final: {valorFinal.ToString("C")}");
            Console.WriteLine($"Acesso ao Lounge VIP: {elegivelVIP}");

            Console.ReadKey();
        }
    }
}