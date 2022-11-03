using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Conta {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(string Titular, int Numero) {
            this.Titular = Titular;
            this.Numero = Numero;
        }
        public Conta(string Titular, int Numero, double deposito) : this(Titular, Numero) {
            Deposito(deposito);
        }

        public void Saque(double saque) {
            Saldo = Saldo - saque - 5.00;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public override string ToString() {
            return "Conta " 
                + Numero 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $" 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
