using System;

namespace Projeto
{
    public class Calculadora
    {
        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Soma(params double[] numeros)
        {
            double resultado = 0.0;
            foreach (double numero in numeros)//para cada numero no array de numeros faça:
            {
                resultado += numero;//soma resultado + numero e atribui o resultado da soma na variavel resultado
            }
            return resultado;
        }

        public double Subtrai(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Subtrai(params double[] numeros)
        {
            double resultado = 0.0;
            foreach (double numero in numeros)
            {
                resultado -= numero;
            }
            return resultado;
        }

        public double Multiplica(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Multiplica(params double[] numeros)
        {
            double resultado = 1.0;
            foreach (double numero in numeros)
            {
                resultado *= numero;
            }
            return resultado;
        }
        
        public double Divide(double n1, double n2)
        {
            double resultado = 0.0;
            resultado = n1 / n2;
            if (double.IsNaN(resultado))//divisão por zero em tipo double não gera exception, então
            {                           //se a variavel resultado for um NaN (Not a Number) força a geração de uma exception
                throw new DivideByZeroException("Erro de divisão por 0.");
            }
            return resultado;
        }

        public double Divide(params double[] numeros)
        {                                   //a divisão precisava começar com um número que não fosse 0, então peguei o número 
            double resultado = numeros[0];  // da primeira posição do array de numeros que foi passado de parametro
            for(int i =1; i<numeros.Length; i++) //percorre o array a partir da segunda posição e faz as divisões
            {
                resultado /= numeros[i];
            }
            if (double.IsNaN(resultado))
            {
                throw new DivideByZeroException("Erro de divisão por 0.");
            }
            return resultado;
        }
    }   
}