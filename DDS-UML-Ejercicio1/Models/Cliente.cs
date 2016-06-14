using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{

    public class Cliente
    {

        private List<Cuenta> cuentas = new List<Cuenta>();
        public int DNI;

        public Cliente(int DNI)
        {
            this.DNI = DNI;
        }

        public List<Cuenta> getCuentas()
        {
            return cuentas;
        }

        public List<Cuenta> addCuenta(Cuenta cuenta)
        {
            cuentas.Add(cuenta);
            return cuentas;
        }
    }
}
