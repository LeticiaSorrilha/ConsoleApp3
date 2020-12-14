using System;
using System.Globalization;

namespace Projeto
{
    class Program
    {
        public static void Main(String[] args)
        {
            Calculadora calc = new Calculadora();

            double[] numeros = { 1.2, 1.3, 1.4, 2.4, 4.4 };

            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = calc.Soma(n1, n2);
            Console.WriteLine("resultado 1 = " + resultado);

            double resultado2 = calc.Soma(numeros);//soma array de números e imprime resultado
            Console.WriteLine("resultado 2 =" + resultado2);


            double resultado3 = calc.Subtrai(n1, n2);
            Console.WriteLine("resultado 3 = " + resultado3);

            double resultado4 = calc.Subtrai(numeros);
            Console.WriteLine("resultado 4 =" + resultado4);

            double resultado5 = calc.Multiplica(n1, n2);
            Console.WriteLine("resultado 5 = " + resultado5);

            double resultado6 = calc.Multiplica(numeros);
            Console.WriteLine("resultado 6 =" + resultado6);

            try
            {//captura a exception gerada pela função Divide da classe Calculadora.
                double resultado7 = calc.Divide(n1, n2);
                Console.WriteLine("resultado 7 = " + resultado7);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                double resultado8 = calc.Divide(numeros);
                Console.WriteLine("resultado 8 =" + resultado8);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            /*os blocos try-catch foram feitos separados para o caso de ocorrer uma exception
             no calculo da variavel resultado7, esta não interfira no cálculo da variável resultado8
             */
            Console.Read();
        }
    }

}