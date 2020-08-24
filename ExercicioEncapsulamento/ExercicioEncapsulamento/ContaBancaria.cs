using System;
using System.Globalization;

namespace ExercicioEncapsulamento {
    class ContaBancaria {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        private double taxa = 5.0;

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;

        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= (valor + taxa);
        }

        public override string ToString() {
            return " Conta " +
                Numero +
                ", Titular: " + Titular +
                ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
