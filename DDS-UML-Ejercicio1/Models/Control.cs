using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Control
    {
        private Banco banco;
    
        public Control ()
        {
            banco = new Banco();
        }

        public int getCliente(int DNI, int saldo)
        {
            Cliente clienteBuscado = banco.getCliente(DNI);

            List <Cuenta> cuentasDelCliente = clienteBuscado.getCuentas();

            int cantidadCuentas = 0;

            foreach (Cuenta cuenta in cuentasDelCliente)
            {
                int saldoActual = cuenta.getSaldo();
                if (this.compararSaldo(saldo, saldoActual))
                {
                    cantidadCuentas++;
                }
            }

            return cantidadCuentas;
        }

        private bool compararSaldo (int saldo, int saldoActual)
        {
            return saldo < saldoActual;
        }


    }
}
