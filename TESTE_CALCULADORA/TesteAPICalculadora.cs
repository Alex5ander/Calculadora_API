using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALCULADORA_API;
using NUnit.Framework;

namespace TESTE_CALCULADORA
{
    [TestFixture]
    public class TesteAPICalculadora
    {
        [TestCase(9, 9, 18)]
        [TestCase(10, 10, 20)]
        public void TestarSoma(double a, double b, double r)
        {
            double resultado = CalculadoraAPI.Somar(a, b);
            Assert.AreEqual(r, resultado);
        }
        [TestCase(9, 9, 0)]
        [TestCase(10, 10, 0)]
        public void TestarSubtracao(double a, double b, double r)
        {
            double resultado = CalculadoraAPI.Subtrair(a, b);
            Assert.AreEqual(r, resultado);
        }
        [TestCase(9, 9, 81)]
        [TestCase(10, 10, 100)]
        public void TestarMultiplicacao(double a, double b, double r)
        {
            double resultado = CalculadoraAPI.Multiplicar(a, b);
            Assert.AreEqual(r, resultado);
        }
        [TestCase(9, 9, 1)]
        [TestCase(10, 10, 1)]
        public void TestarDivisao(double a, double b, double r)
        {
            double resultado = CalculadoraAPI.Dividir(a, b);
            Assert.AreEqual(r, resultado);
        }
    }
}
