using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_API
{
    public class CalculadoraAPI
    {
        public static double somar(double a, double b) {
            return a + b;
        }

        public static double subtrair(double a, double b)
        {
            return a - b;
        }

        public static double multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double dividir(double a, double b)
        {
            return a / b;
        }
    }
}
