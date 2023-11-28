using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Interfaz donde se encontrará el menú.
        /// 171123 - chi
        /// </summary>
        public int menu();

        public string pedirDNI();

        public int seleccion();
    }
}
