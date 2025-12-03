using System;

class Sorveteria
{
    // Preço de cada sabor de sorvete
    const double PRECO_CHOCOLATE = 5, PRECO_MORANGO = 6, PRECO_FLOCOS = 4;

    static double calcularTotalPedido(double qtdChocolate, double qtdMorango, double qtdFlocos)
    {
        double totalChocolate = qtdChocolate * PRECO_CHOCOLATE;
        double totalMorango = qtdMorango * PRECO_MORANGO;
        double totalFlocos = qtdFlocos * PRECO_FLOCOS;

        double valorTotalPedido = totalChocolate + totalMorango + totalFlocos;
        return valorTotalPedido;
    }

    static void Main()
    {
        // Quantidade de sorvetes pedidos pelo cliente
        Console.Write("Quantos sorvetes de chocolate? ");
        int qtdChocolate = int.Parse(Console.ReadLine());

        Console.Write("Quantos sorvetes de morango? ");
        int qtdMorango = int.Parse(Console.ReadLine());

        Console.Write("Quantos sorvetes de flocos? ");
        int qtdFlocos = int.Parse(Console.ReadLine());

        //Cálculo do total do pedido
        double valorTotalPedido = calcularTotalPedido(qtdChocolate, qtdMorango, qtdFlocos);

        // Aplicação de desconto
        int qtdTotalSorvetes = qtdChocolate + qtdMorango + qtdFlocos;

        if (qtdTotalSorvetes > 5) // Mais do que 5 sorvetes tem desconto de 10%
        {
            valorTotalPedido -= valorTotalPedido / 10;
        }

        //Verificação de promoção de cobertura gratuita e resumo
        if (valorTotalPedido > 20) // Pedido acima de R$ 20,00 ganha cobertura gratuita
        {
            Console.WriteLine($"Total do pedido: R$ {valorTotalPedido:0.00} e com cobertura gratuita!");
        }
        else
        {
            Console.WriteLine($"Total do pedido: R$ {valorTotalPedido:0.00}.");
        }
    }
}
