using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarDeAlta.Dtos;

namespace DarDeAlta.Servicios
{
    internal class CuentaImplementacion : CuentaInterfaz
    {
        public void nuevaCuenta(List<CuentasDto> cuentaAntigua)
        {
            CuentasDto cuentaNueva = crearCuentaNueva();
            cuentaAntigua.Add(cuentaNueva);

        }
        /// <summary>
        /// Dar de alta una cuenta bancaria asociada con el cliente.
        /// </summary>
        /// <returns>La nueva cuenta Bancaria con la información solicitada</returns>
        private CuentasDto crearCuentaNueva() 
            { 
                CuentasDto nueva = new CuentasDto();

                Console.WriteLine("Datos de la Cuenta");

                Console.WriteLine("ID: ");
                nueva.IdCuenta = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("ISBAN: ");
                nueva.ISBANCuenta = Console.ReadLine();

                Console.WriteLine("Fecha de Alta: ");
                nueva.FechaCuentaAlta = Console.ReadLine();

                Console.WriteLine("ID del usuario");
                nueva.IdCLiente = Convert.ToInt64(Console.ReadLine());

            return nueva;

            }
            
        

    }
}
