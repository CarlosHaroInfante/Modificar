using DarDeAlta.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal interface NuevoInterfaz
    {
        /// <summary>
        /// Implementación donde se encuentra la copia de la lista ClienteDto.
        /// 171123 - chi
        /// </summary>
        public void darAltaCliente(List<ClientesDto> listaAntigua);

        /// <summary>
        /// Implementación donde se encuentra la copia de la lista ClienteDto.
        /// 171123 - chi
        /// </summary>
        public void borrarCliente(List<ClientesDto> listaAntigua);

        public void modificarCliente(List<ClientesDto> listaAntigua);
    }
}
