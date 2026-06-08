using System;
using Xunit;
// Referencia a la clase Calculator desde el proyecto principal
// En un proyecto real se referenciaría con ProjectReference

namespace CalculadoraApp.Tests
{
    /// <summary>
    /// Pruebas unitarias para la clase Calculator
    /// </summary>
    public class CalculatorTests
    {
        private readonly Calculator _calc = new Calculator();

        [Fact]
        public void Sumar_RetornaResultadoCorrecto()
        {
            var resultado = _calc.Sumar(10, 5);
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Restar_RetornaResultadoCorrecto()
        {
            var resultado = _calc.Restar(10, 5);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Multiplicar_RetornaResultadoCorrecto()
        {
            var resultado = _calc.Multiplicar(10, 5);
            Assert.Equal(50, resultado);
        }

        [Fact]
        public void Dividir_RetornaResultadoCorrecto()
        {
            var resultado = _calc.Dividir(10, 5);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir_PorCero_LanzaExcepcion()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(10, 0));
        }

        [Fact]
        public void Sumar_NumerosNegativos_RetornaResultadoCorrecto()
        {
            var resultado = _calc.Sumar(-3, -7);
            Assert.Equal(-10, resultado);
        }
    }
}
