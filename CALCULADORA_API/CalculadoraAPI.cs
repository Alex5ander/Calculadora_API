using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA_API
{
    public class CalculadoraAPI
    {
        public static double Somar(double a, double b) {
            return a + b;
        }

        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            return a / b;
        }
    }
}
