using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cuenta
    {

        private int numeroDeCuenta;
        private int saldo;

        public Cuenta (int numero, int saldo)
        {
            this.saldo = saldo;
            numeroDeCuenta = numero;
        }

        public int getSaldo ()
        {
            return saldo;
        }

    }
}
