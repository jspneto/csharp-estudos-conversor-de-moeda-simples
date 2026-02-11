using System;

namespace ConversorMoedaSimples;

class ConversorDeMoeda
{
    public static double ImpostoIof = 6.00;

    public static double ConverterParaReal(double cotacao, double dolar)
    {
        return cotacao * dolar;
    }

    public static double CalcularValorFinal(double cotacao, double dolar)
    {
        double valorConvertido = ConverterParaReal(cotacao, dolar);
        valorConvertido+=valorConvertido*(ImpostoIof/100.0);
        return valorConvertido;
    }
}