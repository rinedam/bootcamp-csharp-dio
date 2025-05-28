using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrograma.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Classe que representa uma calculadora simples.
        /// </summary>
        /// <param name="x">Primeiro número inteiro para calcular</param>
        /// <param name="y">Segundo número inteiro para calcular</param>
        public void Somar(int x, int y)
        {
            System.Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            System.Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            if (y == 0 || x == 0)
            {
                System.Console.WriteLine("Divisão por zero não é permitida.");
            }
            else
            {
                System.Console.WriteLine($"{x} / {y} = {x / y}");
            }
        }
        public void Potencia(int x, int y)
        {
            System.Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }
        public void Seno(int angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            System.Console.WriteLine($"Seno de {angulo}° = {Math.Sin(radianos)}");
        }
        public void Coseno(int angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            System.Console.WriteLine($"Coseno de {angulo}° = {Math.Cos(radianos)}");
        }
        public void Tangente(int angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            System.Console.WriteLine($"Tangente de {angulo}° = {Math.Tan(radianos)}");
        }
    }
}