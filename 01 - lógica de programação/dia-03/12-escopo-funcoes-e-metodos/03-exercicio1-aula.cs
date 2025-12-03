using System;

class Sorveteria
{
    // Preço de cada sabor de sorvete
    const double PRECO_CHOCOLATE = 5, PRECO_MORANGO = 6, PRECO_FLOCOS = 4;
    
    static double CalcularTotalPedido(double qtdChocolate, double qtdMorango, double qtdFlocos)
    {
        double totalChocolate = qtdChocolate * PRECO_CHOCOLATE;
        double totalMorango = qtdMorango * PRECO_MORANGO;
        double totalFlocos = qtdFlocos * PRECO_FLOCOS;

        double totalPedido = totalChocolate + totalMorango + totalFlocos;
        return totalPedido;
    }

    static void AplicarPromocao(int quantidadeChocolate, int quantidadeMorango, int quantidadeFlocos, double totalPedido)
    {
        // Aplicação de desconto
        int totalSorvetes = quantidadeChocolate + quantidadeMorango + quantidadeFlocos;

        if (totalSorvetes > 5) // Mais do que 5 sorvetes tem desconto de 10%
        {
            totalPedido -= totalPedido / 10;
        }

        // Verificação de promoção de cobertura gratuita e impressão do resumo
        if (totalPedido > 20) // Pedido acima de R$ 20,00 ganha cobertura gratuita
        {
            Console.WriteLine($"Total do pedido: R$ {totalPedido:0.00} e com cobertura gratuita!");
        }
        else
        {
            Console.WriteLine($"Total do pedido: R$ {totalPedido:0.00}.");
        }
    }

    static void Main()
    {
        // Quantidade de sorvetes pedidos pelo cliente
        Console.Write("Quantos sorvetes de chocolate? ");
        int quantidadeChocolate = int.Parse(Console.ReadLine());

        Console.Write("Quantos sorvetes de morango? ");
        int quantidadeMorango = int.Parse(Console.ReadLine());

        Console.Write("Quantos sorvetes de flocos? ");
        int quantidadeFlocos = int.Parse(Console.ReadLine());

        // Cálculo do total do pedido
        double totalPedido = CalcularTotalPedido(quantidadeChocolate, quantidadeMorango, quantidadeFlocos);

        AplicarPromocao(quantidadeChocolate, quantidadeMorango, quantidadeFlocos, totalPedido);
    }
}
