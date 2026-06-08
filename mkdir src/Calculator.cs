using System;

namespace CalculadoraApp
{
    /// <summary>
    /// Clase calculadora con operaciones básicas
    /// </summary>
    public class Calculator
    {
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir entre cero.");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora C# - Aplicaciones y Servicios Web ===");
            Console.WriteLine("Guía de Trabajo No.5 - CI/CD con GitHub Actions");
            Console.WriteLine("=====================================================");

            var calc = new Calculator();

            Console.WriteLine($"Suma:          10 + 5  = {calc.Sumar(10, 5)}");
            Console.WriteLine($"Resta:         10 - 5  = {calc.Restar(10, 5)}");
            Console.WriteLine($"Multiplicación: 10 * 5 = {calc.Multiplicar(10, 5)}");
            Console.WriteLine($"División:      10 / 5  = {calc.Dividir(10, 5)}");

            Console.WriteLine("\n[OK] Aplicación ejecutada correctamente.");
        }
    }
}
