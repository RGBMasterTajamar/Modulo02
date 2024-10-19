using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoC__Raul_Gonzalez.Ejercicio1
{
    internal class Banco
    {

        Cliente cliente1, cliente2, cliente3;

        public Banco() 
        {
            cliente1 = new Cliente("Cliente 1");
            cliente2 = new Cliente("Cliente 2");
            cliente3 = new Cliente("Cliente 3");
        }

        public void Operar()
        {
            cliente1.HacerIngreso(150);
            cliente2.HacerIngreso(550);
            cliente3.HacerIngreso(850);
        }

        public void DepositosTotales()
        {
            int t = cliente1.RetornarMontante() +
                cliente2.RetornarMontante() +
                cliente3.RetornarMontante();

            Console.WriteLine($"El total del dinero es {t}");
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

    }
}
