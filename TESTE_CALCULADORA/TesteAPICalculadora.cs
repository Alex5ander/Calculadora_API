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
        [Test]
        public void TestarSoma()
        {
            double resultado = CalculadoraAPI.Somar(0, 5);
            Assert.AreEqual(13, resultado);
            resultado = CalculadoraAPI.Somar(4, 15);
            Assert.AreEqual(19, resultado);
        }
        [Test]
        public void TestarSubtracao()
        {
            double resultado = CalculadoraAPI.Subtrair(7, 5);
            Assert.AreEqual(2, resultado);
            resultado = CalculadoraAPI.Subtrair(4, 6);
            Assert.AreEqual(-2, resultado);
        }
        [Test]
        public void TestarMultiplicacao()
        {
            double resultado = CalculadoraAPI.Multiplicar(7, 5);
            Assert.AreEqual(35, resultado);
            resultado = CalculadoraAPI.Multiplicar(4, 6);
            Assert.AreEqual(24, resultado);
        }
        [Test]
        public void TestarDivisao()
        {
            double resultado = CalculadoraAPI.Dividir(2, 1);
            Assert.AreEqual(2, resultado);
            resultado = CalculadoraAPI.Dividir(8, 4);
            Assert.AreEqual(2, resultado);
        }
    }
}
