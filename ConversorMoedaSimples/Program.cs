using System;
using System.Globalization;

namespace ConversorMoedaSimples;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Digite a cotação do dólar: R$ ");
        double cotacao = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o valor em dólar: U$ ");
        double dolar = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double valorFinal = ConversorDeMoeda.CalcularValorFinal(cotacao, dolar);

        Console.WriteLine($"Valor a ser pago em reais: R$ {valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
