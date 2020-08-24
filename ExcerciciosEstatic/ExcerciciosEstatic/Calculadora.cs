using System;
using System.Globalization;
namespace ExcerciciosEstatic {
    class Calculadora {
        public static double CotacaoDolar = 3.10;
        public static double IOF = 6.0;

        public static double ConversorMoeda(double valor) {
            double calcValorCotacao = valor * CotacaoDolar;
            return (calcValorCotacao * IOF / 100) + (calcValorCotacao);
        }
    }
}
