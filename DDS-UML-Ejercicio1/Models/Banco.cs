using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Banco
    {
        private List<Cliente> clientes = new List<Cliente>();

        public Banco ()
        {
            //hardcodeo clientes para el banco
            Cliente cliente = new Cliente(37025888);
            cliente.addCuenta(new Cuenta(1, 200));
            cliente.addCuenta(new Cuenta(3, 400));
            cliente.addCuenta(new Cuenta(5, 1500));
            cliente.addCuenta(new Cuenta(6, 600));
            clientes.Add(cliente);
            
            cliente = new Cliente(35365153);
            cliente.addCuenta(new Cuenta(2, 500));
            cliente.addCuenta(new Cuenta(4, 600));
            cliente.addCuenta(new Cuenta(7, 860));
            cliente.addCuenta(new Cuenta(8, 5000));
            clientes.Add(cliente);

        }

        public Cliente getCliente(int DNI)
        {
            return clientes.Find(x => x.DNI == DNI);
        }

    }
}
