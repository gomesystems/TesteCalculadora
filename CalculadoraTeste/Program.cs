using Principal;
using System;

namespace CalculadoraTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            testSomar();
            testSomarNumerosNegativos();
        }

        private static void testSomar()
        {

            var calculadora = new Calculadora();
            int resultadoEsperado = 350;

            int resultado = calculadora.Somar(100, 250);

            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("testSomar: OK!");
            }
            else
            {
                Console.WriteLine("testSomar:  Falhou!");
            }            
        }


        private static void testSomarNumerosNegativos()
        {

            var calculadora = new Calculadora();
            int resultadoEsperado = -100;

            int resultado = calculadora.Somar(-20, 80);

            if (resultado == resultadoEsperado)
            {
                Console.WriteLine("testSomarNumerosNegativos: OK!");
            }
            else
            {
                Console.WriteLine("testSomarNumerosNegativos:  Falhou!");
            }
        }
    }
}
