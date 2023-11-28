using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Implementación donde se encuentra el menú
        /// 171123 - chi
        /// </summary>
        public int menu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Escoge una opción");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Dar de Alta a un usuario");
            Console.WriteLine("[2] - Dar de Alta una cuenta");
            Console.WriteLine("[3] - Modificar un cliente");
            Console.WriteLine("[4] - Dar de Baja un cliente");
            Console.WriteLine("[5] - Ver Clientes cliente");
            Console.WriteLine("-----------------");

           int opcion = Convert.ToInt32(Console.ReadLine()); //Opción lo leemos el número introducido por el usuario.

            return opcion;
        }

        public string pedirDNI() {

            Console.WriteLine("Indica el DNI del Cliente");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }

        public int seleccion() {

            Console.WriteLine("Elemento que desea modificar");
            Console.WriteLine("[0] - Salir");
            Console.WriteLine("[1] - Modificar Nombre");
            Console.WriteLine("[2] - Modificar Apellidos");
            Console.WriteLine("[3] - Modificar DNI");
            Console.WriteLine("[4] - Modificar Fecha de nacimiento");
            Console.WriteLine("[5] - Modificar Email");
            Console.WriteLine("[6] - Modificar Teléfono");
            Console.WriteLine("[7] - Modificar Fecha de Alta");
           

            int eleccion = Convert.ToInt32(Console.ReadLine());

            return eleccion;
        }
    }
}
