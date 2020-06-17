using System;

namespace Aula_19__
{
    public class Ingresso
    {
        public float Valor {get; set; }

        public void ImprimirVarlor(){
            System.Console.WriteLine($"Valor do ingresso comum é de R${Valor}.");
        }

        public float ValorMeia { get; set; }
        
        public void MostrarValorMeia()
        {
            float resultado = Valor - ValorMeia;
            System.Console.WriteLine($"Valor da meia entrada é de R${resultado}.");
        }
    }

}