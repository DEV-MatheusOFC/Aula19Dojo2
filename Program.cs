using System;

namespace Aula_19__
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP bilhete = new IngressoVIP();
            bilhete.Valor = 20f;
            bilhete.ValorMeia = 10f;
            bilhete.MostrarValorMeia();
            bilhete.ValorAdicional = 15.50f;
            bilhete.ImprimirVarlor();

            bilhete.MostrarValorVIP();
            System.Console.WriteLine($"A diferença entre os valores de VIP e Comum é de R${bilhete.ValorAdicional}.");



        }
    }
}
